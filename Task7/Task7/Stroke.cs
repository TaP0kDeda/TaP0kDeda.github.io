using System;
using System.Drawing;
using System.Drawing.Drawing2D;

[Serializable]
public class Stroke
{
    public Stroke()
    {
        Color = Color.Black;
        Width = 1f;
        DashStyle = DashStyle.Solid;
    }

    public Color Color { get; set; }
    public float Width { get; set; }
    public DashStyle DashStyle { get; set; }

    public Pen UpdatePen(Pen pen)
    {
        if (pen == null) throw new ArgumentNullException(nameof(pen));
        pen.Color = Color;
        pen.Width = Width;
        pen.DashStyle = DashStyle;
        return pen;
    }
}
