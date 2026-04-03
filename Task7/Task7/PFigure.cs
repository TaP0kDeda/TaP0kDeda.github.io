using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

[Serializable]


internal class PFigure : Figure
{
    public PFigure(Rectangle bounds, Stroke stroke, Color fillColor) : base(bounds, stroke, fillColor) { }

    public override void Draw(Graphics g)
    {
        using (var path = GetPath())
        using (var pen = GetPen())
        using (var brush = GetFillBrush())
        {
            if (FillColor != Color.Transparent)
                g.FillPath(brush, path);
            g.DrawPath(pen, path);
        }
    }

    private GraphicsPath GetPath()
    {
        var path = new GraphicsPath();
        int w = Bounds.Width, h = Bounds.Height;
        int legWidth = Math.Max(10, w / 4);
        int topHeight = Math.Max(10, h / 4);

        // верхняя перекладина
        var topRect = new Rectangle(Bounds.X, Bounds.Y, w, topHeight);
        // левая стойка
        var leftRect = new Rectangle(Bounds.X, Bounds.Y + topHeight, legWidth, h - topHeight);
        // правая стойка
        var rightRect = new Rectangle(Bounds.X + w - legWidth, Bounds.Y + topHeight, legWidth, h - topHeight);

        path.AddRectangle(topRect);
        path.AddRectangle(leftRect);
        path.AddRectangle(rightRect);
        return path;
    }

    public override bool HitTest(Point point)
    {
        using (var path = GetPath())
            return path.IsVisible(point);
    }

    public override Figure Clone() => new PFigure(Bounds, new Stroke { Color = Stroke.Color, Width = Stroke.Width }, FillColor);
}
