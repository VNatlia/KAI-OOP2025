using MemoryPack;
using System;

[MemoryPackable]
public partial class Vector
{
    public string Color { get; set; } = "";
    public double X { get; set; }
    public double Y { get; set; }

    public Vector() { }

    [MemoryPackConstructor]
    public Vector(string color, double x, double y)
    {
        Color = color;
        X = x;
        Y = y;
    }

    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

    public void Increase(double dx, double dy)
    {
        X += dx;
        Y += dy;
    }

    public override string ToString()
    {
        return $"Колір: {Color} | Кінець: ({X}, {Y}) | Довжина = {Length():F2}";
    }
}
