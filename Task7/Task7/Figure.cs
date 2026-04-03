using System;
using System.Drawing;
using System.Drawing.Drawing2D;

[Serializable]
public abstract class Figure
{
    public Rectangle Bounds { get; set; }
    public Stroke Stroke { get; set; }
    public Color FillColor { get; set; }

    protected Figure(Rectangle bounds, Stroke stroke, Color fillColor)
    {
        Bounds = bounds;
        Stroke = stroke ?? new Stroke();
        FillColor = fillColor;
    }

    public abstract void Draw(Graphics g);
    public abstract bool HitTest(Point point);
    public abstract Figure Clone();

    public void Move(int dx, int dy)
    {
        Bounds = new Rectangle(Bounds.X + dx, Bounds.Y + dy, Bounds.Width, Bounds.Height);
    }

    public void MoveTo(Point newLocation)
    {
        Bounds = new Rectangle(newLocation, Bounds.Size);
    }

    protected Pen GetPen() => Stroke.UpdatePen(new Pen(Color.Black));
    protected Brush GetFillBrush() => new SolidBrush(FillColor);
}
