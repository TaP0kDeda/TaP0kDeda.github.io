using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

[Serializable]
public class CrossFigure : Figure
{
    public CrossFigure(Rectangle bounds, Stroke stroke, Color fillColor) : base(bounds, stroke, fillColor) { }

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
        int barWidth = w / 3;
        int barHeight = h / 3;

        // горизонтальная полоса
        var horzRect = new Rectangle(Bounds.X, Bounds.Y + (h - barHeight) / 2, w, barHeight);
        // вертикальная полоса
        var vertRect = new Rectangle(Bounds.X + (w - barWidth) / 2, Bounds.Y, barWidth, h);

        path.AddRectangle(horzRect);
        path.AddRectangle(vertRect);
        return path;
    }

    public override bool HitTest(Point point)
    {
        using (var path = GetPath())
            return path.IsVisible(point);
    }

    public override Figure Clone() => new CrossFigure(Bounds, new Stroke { Color = Stroke.Color, Width = Stroke.Width }, FillColor);
}
