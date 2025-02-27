using System;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть рядок: ");
            string input = Console.ReadLine();

            // Створення об'єктів класу
            StringClass myString = new StringClass(input);
            StringClass copiedString = new StringClass(myString);

            // Виведення результатів
            Console.WriteLine("Введений рядок: " + myString.GetValue());
            Console.WriteLine("Довжина рядка: " + myString.GetLength());
            Console.WriteLine("Обернений рядок: " + myString.ReverseString());
        }
    }
}
