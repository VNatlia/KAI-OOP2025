using System;
using FiguresLib; // Підключаємо бібліотеку

class Program
{
    static void Main()
    {
        Triangle t = new Triangle(0, 0, 3, 0, 3, 4);
        Console.WriteLine($"Периметр: {t.Perimeter()}");
        Console.WriteLine($"Площа: {t.Area()}");
    }
}
