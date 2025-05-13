using System;
using TextLibrary;

class Program
{
    static void Main()
    {
        Text text = new();
        Cleaner cleaner = new();

        text.AddLine(new Line("   This   is   a     line.  "));
        text.AddLine(new Line("Another      line   here. "));
        text.AddLine(new Line("   Short."));

        Console.WriteLine("Before cleaning:");
        foreach (var line in text.GetLines())
        {
            Console.WriteLine($"'{line}'");
        }

        text.TrimSpaces(cleaner);

        Console.WriteLine("\nAfter cleaning:");
        foreach (var line in text.GetLines())
        {
            Console.WriteLine($"'{line}'");
        }

        Console.WriteLine($"\nShortest line length: {text.GetShortestLineLength()}");
        Console.WriteLine($"Consonant percentage: {text.GetTotalConsonantPercentage():F2}%");
    }
}

   
