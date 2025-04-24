using System;
using StringLibrary;

class Program
{
    static void Main()
    {
        Digits d = new Digits("1234556789");
        Letters l = new Letters("Alphabet with a and A");

        Console.WriteLine("--- Digits ---");
        DisplayInformation.ProcessString(d);

        Console.WriteLine("\n--- Letters ---");
        DisplayInformation.ProcessString(l);
    }
}
