using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

[Serializable]
public class Square : Figure
{
    public Square(Rectangle bounds, Stroke stroke, Color fillColor)
        : base(new Rectangle(bounds.X, bounds.Y, bounds.Width, bounds.Width), stroke, fillColor) { }

    public override void Draw(Graphics g)
    {
        using (var pen = GetPen())
        using (var brush = GetFillBrush())
        {
            if (FillColor != Color.Transparent)
                g.FillRectangle(brush, Bounds);
            g.DrawRectangle(pen, Bounds);
        }
    }

    public override bool HitTest(Point point) => Bounds.Contains(point);

    public override Figure Clone() => new Square(Bounds, new Stroke { Color = Stroke.Color, Width = Stroke.Width }, FillColor);
}
