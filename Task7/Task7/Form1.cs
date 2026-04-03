using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Task7
{
    public partial class MainForm : Form
    {
        private FigureManager _manager;
        private enum DrawTool { None, Square, Rectangle, Cross, PShaped }
        private DrawTool _currentTool = DrawTool.None;
        private Point _startPoint;
        private bool _isDrawing;
        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            comboBoxWidth.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            comboBoxWidth.SelectedItem = 1;
            comboBoxWidth.SelectedIndexChanged += (s, e) => ApplyStrokeToSelected();

            buttonColor.Click += (s, e) => ChangeStrokeColor();
            buttonFill.Click += (s, e) => ChangeFillColor();

            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;
            _manager = new FigureManager();
        }

        private void InitializeCustomComponents()
        {
            // Привязка событий к существующим кнопкам (назначаются в дизайнере)
            menuNew.Click += (s, e) => NewFile();
            menuOpen.Click += (s, e) => OpenFile();
            menuSave.Click += (s, e) => SaveFile();

            btnNew.Click += (s, e) => NewFile();
            btnOpen.Click += (s, e) => OpenFile();
            btnSave.Click += (s, e) => SaveFile();
            btnCut.Click += (s, e) => _manager.CutSelected();
            btnCopy.Click += (s, e) => _manager.CopySelected();
            btnPaste.Click += (s, e) => _manager.Paste(new Point(10, 10));
            btnUndo.Click += (s, e) => _manager.Undo();
            btnRedo.Click += (s, e) => _manager.Redo();

            btnSquare.Click += (s, e) => _currentTool = DrawTool.Square;
            btnRectangle.Click += (s, e) => _currentTool = DrawTool.Rectangle;
            btnCross.Click += (s, e) => _currentTool = DrawTool.Cross;
            btnPShaped.Click += (s, e) => _currentTool = DrawTool.PShaped;
        }

        private void NewFile()
        {
            if (MessageBox.Show("Создать новый рисунок?", "Векторный редактор", MessageBoxButtons.YesNo) == DialogResult.Yes)
                _manager.ClearAll();
        }

        private void OpenFile()
        {
            using (var ofd = new OpenFileDialog { Filter = "Vector files (*.vec)|*.vec" })
                if (ofd.ShowDialog() == DialogResult.OK)
                    _manager.LoadFromFile(ofd.FileName);
        }

        private void SaveFile()
        {
            using (var sfd = new SaveFileDialog { Filter = "Vector files (*.vec)|*.vec" })
                if (sfd.ShowDialog() == DialogResult.OK)
                    _manager.SaveToFile(sfd.FileName);
        }

        private void ChangeStrokeColor()
        {
            using (var cd = new ColorDialog())
                if (cd.ShowDialog() == DialogResult.OK && _manager.SelectedFigure != null)
                    _manager.UpdateStrokeOfSelected(cd.Color, (float)(int)comboBoxWidth.SelectedItem);
        }

        private void ApplyStrokeToSelected()
        {
            if (_manager.SelectedFigure != null && comboBoxWidth.SelectedItem != null)
                _manager.UpdateStrokeOfSelected(_manager.SelectedFigure.Stroke.Color, (float)(int)comboBoxWidth.SelectedItem);
        }

        private void ChangeFillColor()
        {
            using (var cd = new ColorDialog())
                if (cd.ShowDialog() == DialogResult.OK && _manager.SelectedFigure != null)
                    _manager.UpdateFillOfSelected(cd.Color);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (var fig in _manager.Figures)
                fig.Draw(e.Graphics);

            if (_manager.SelectedFigure != null)
                DrawSelectionMarkers(e.Graphics, _manager.SelectedFigure.Bounds);
        }

        private void DrawSelectionMarkers(Graphics g, Rectangle rect)
        {
            using (var pen = new Pen(Color.Blue, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
                g.DrawRectangle(pen, rect);

            int markerSize = 6;
            Point[] points = {
            new Point(rect.Left - markerSize/2, rect.Top - markerSize/2),
            new Point(rect.Left + rect.Width/2 - markerSize/2, rect.Top - markerSize/2),
            new Point(rect.Right - markerSize/2, rect.Top - markerSize/2),
            new Point(rect.Left - markerSize/2, rect.Top + rect.Height/2 - markerSize/2),
            new Point(rect.Right - markerSize/2, rect.Top + rect.Height/2 - markerSize/2),
            new Point(rect.Left - markerSize/2, rect.Bottom - markerSize/2),
            new Point(rect.Left + rect.Width/2 - markerSize/2, rect.Bottom - markerSize/2),
            new Point(rect.Right - markerSize/2, rect.Bottom - markerSize/2)
        };
            using (var brush = new SolidBrush(Color.White))
            using (var outline = new Pen(Color.Black))
                foreach (var p in points)
                {
                    g.FillRectangle(brush, p.X, p.Y, markerSize, markerSize);
                    g.DrawRectangle(outline, p.X, p.Y, markerSize, markerSize);
                }
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (_currentTool != DrawTool.None && e.Button == MouseButtons.Left)
            {
                _isDrawing = true;
                _startPoint = e.Location;
            }
            else if (e.Button == MouseButtons.Left)
            {
                _manager.SelectFigureAtPoint(e.Location);
            }
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
                panelCanvas.Invalidate();
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isDrawing || _currentTool == DrawTool.None) return;
            _isDrawing = false;

            Rectangle bounds = GetNormalizedRectangle(_startPoint, e.Location);
            if (bounds.Width < 5 || bounds.Height < 5) return;

            Stroke stroke = new Stroke { Color = Color.Black, Width = (float)(int)comboBoxWidth.SelectedItem };
            Color fill = Color.Transparent; // начальная заливка прозрачная

            Figure figure = null;
            switch (_currentTool)
            {
                case DrawTool.Square:
                    figure = new Square(bounds, stroke, fill);
                    break;
                case DrawTool.Rectangle:
                    figure = new RectangleFigure(bounds, stroke, fill);
                    break;
                case DrawTool.Cross:
                    figure = new CrossFigure(bounds, stroke, fill);
                    break;
                case DrawTool.PShaped:
                    figure = new PFigure(bounds, stroke, fill);
                    break;
            }
            if (figure != null)
                _manager.AddFigure(figure);
            panelCanvas.Invalidate();
        }

        private Rectangle GetNormalizedRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int w = Math.Abs(p1.X - p2.X);
            int h = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, w, h);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (_manager.SelectedFigure == null) return;
            int step = e.Shift ? 1 : 5;
            int dx = 0, dy = 0;
            if (e.KeyCode == Keys.Left) dx = -step;
            else if (e.KeyCode == Keys.Right) dx = step;
            else if (e.KeyCode == Keys.Up) dy = -step;
            else if (e.KeyCode == Keys.Down) dy = step;
            else return;

            _manager.MoveSelectedFigure(dx, dy);
            panelCanvas.Invalidate();
            e.Handled = true;
        }
    }
}
