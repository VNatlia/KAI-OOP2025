using System;
using ExpressionLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression[] expressions = new Expression[]
            {
                new Expression(2, 3, 8),     // OK
                new Expression(1, 4, -2),    // log(d / 4) < 0
                new Expression(1, 3, 4)      // знаменник = 0
            };

            for (int i = 0; i < expressions.Length; i++)
            {
                try
                {
                    double result = expressions[i].Calculate();
                    Console.WriteLine($"Result {i + 1}: {result:F4}");
                }
                catch (InvalidArgumentException ex)
                {
                    Console.WriteLine($"Error in object {i + 1}: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error in object {i + 1}: {ex.Message}");
                }
            }
        }
    }
}
