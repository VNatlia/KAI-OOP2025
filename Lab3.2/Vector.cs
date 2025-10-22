using System;

public class Vector : IComparable<Vector>
{
    public string Color { get; set; }   // колір лінії
    public double X { get; set; }       // координата X
    public double Y { get; set; }       // координата Y

    public Vector(string color, double x, double y)
    {
        Color = color;
        X = x;
        Y = y;
    }

    // Метод для обчислення довжини вектора
    public double Length
    {
       get
       {
        return Math.Sqrt(X * X + Y * Y);
       }
    }

    // Збільшення вектора на певний відрізок
    public void Increase(double dx, double dy)
    {
        X += dx;
        Y += dy;
    }

    // Виведення інформації про вектор
    public void PrintInfo()
    {
        Console.WriteLine($"Вектор {Color}: ({X}, {Y}), Довжина = {Length:F2}");
    }

    // Порівняння за довжиною
    public int CompareTo(Vector other)
    {
        if (other == null) return 1;
        return Length.CompareTo(other.Length);
    }

    public override string ToString()
    {
        return $"{Color} ({X}, {Y}), L = {Length:F2}";
    }
}
