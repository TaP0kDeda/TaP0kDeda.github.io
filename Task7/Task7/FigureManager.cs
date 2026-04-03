using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class FigureManager
{
    private List<Figure> _figures;
    private Figure _selectedFigure;
    private readonly StackMemory _undoStack;
    private readonly StackMemory _redoStack;
    private Figure _clipboardFigure;

    public FigureManager(int undoDepth = 20)
    {
        _figures = new List<Figure>();
        _undoStack = new StackMemory(undoDepth);
        _redoStack = new StackMemory(undoDepth);
    }

    public IReadOnlyList<Figure> Figures => _figures;
    public Figure SelectedFigure => _selectedFigure;

    public event Action StateChanged;

    private void SaveStateToUndo()
    {
        using (var ms = new MemoryStream())
        {
            SerializeToStream(ms, _figures);
            _undoStack.Push(ms);
        }
        _redoStack.Clear();
        StateChanged?.Invoke();
    }

    private void RestoreFromStack(StackMemory stack, StackMemory otherStack)
    {
        if (stack.Count == 0) return;
        using (var ms = new MemoryStream())
        {
            // сохраняем текущее состояние в другой стек
            using (var currentMs = new MemoryStream())
            {
                SerializeToStream(currentMs, _figures);
                otherStack.Push(currentMs);
            }
            // восстанавливаем из выбранного стека
            stack.Pop(ms);
            _figures = DeserializeFromStream(ms).ToList();
            _selectedFigure = null;
            StateChanged?.Invoke();
        }
    }

    public void Undo() => RestoreFromStack(_undoStack, _redoStack);
    public void Redo() => RestoreFromStack(_redoStack, _undoStack);

    public void AddFigure(Figure figure)
    {
        SaveStateToUndo();
        _figures.Add(figure);
        SelectFigure(figure);
    }

    public void RemoveFigure(Figure figure)
    {
        if (figure == null) return;
        SaveStateToUndo();
        _figures.Remove(figure);
        if (_selectedFigure == figure) _selectedFigure = null;
    }

    public void SelectFigure(Figure figure)
    {
        _selectedFigure = figure;
        StateChanged?.Invoke();
    }

    public void SelectFigureAtPoint(Point point)
    {
        var hit = _figures.LastOrDefault(f => f.HitTest(point));
        SelectFigure(hit);
    }

    public void MoveSelectedFigure(int dx, int dy)
    {
        if (_selectedFigure == null) return;
        SaveStateToUndo();
        _selectedFigure.Move(dx, dy);
        StateChanged?.Invoke();
    }

    public void UpdateStrokeOfSelected(Color color, float width)
    {
        if (_selectedFigure == null) return;
        SaveStateToUndo();
        _selectedFigure.Stroke.Color = color;
        _selectedFigure.Stroke.Width = width;
        StateChanged?.Invoke();
    }

    public void UpdateFillOfSelected(Color fillColor)
    {
        if (_selectedFigure == null) return;
        SaveStateToUndo();
        _selectedFigure.FillColor = fillColor;
        StateChanged?.Invoke();
    }

    public void CopySelected()
    {
        if (_selectedFigure != null)
            _clipboardFigure = _selectedFigure.Clone();
    }

    public void CutSelected()
    {
        if (_selectedFigure == null) return;
        CopySelected();
        RemoveFigure(_selectedFigure);
        _selectedFigure = null;
    }

    public void Paste(Point offset)
    {
        if (_clipboardFigure == null) return;
        var newFigure = _clipboardFigure.Clone();
        newFigure.Move(offset.X, offset.Y);
        AddFigure(newFigure);
    }

    public void ClearAll()
    {
        SaveStateToUndo();
        _figures.Clear();
        _selectedFigure = null;
    }

    public void SaveToFile(string filename)
    {
        using (var fs = new FileStream(filename, FileMode.Create))
            SerializeToStream(fs, _figures);
    }

    public void LoadFromFile(string filename)
    {
        using (var fs = new FileStream(filename, FileMode.Open))
        {
            var loaded = DeserializeFromStream(fs).ToList();
            SaveStateToUndo();
            _figures = loaded;
            _selectedFigure = null;
            StateChanged?.Invoke();
        }
    }

    private void SerializeToStream(Stream stream, List<Figure> list)
    {
        var formatter = new BinaryFormatter();
        formatter.Serialize(stream, list);
        stream.Position = 0;
    }

    private static IEnumerable<Figure> DeserializeFromStream(Stream stream)
    {
        try
        {
            var formatter = new BinaryFormatter();
            stream.Position = 0;
            return (List<Figure>)formatter.Deserialize(stream);
        }
        catch (SerializationException)
        {
            return new List<Figure>();
        }
    }
}
