using System;

namespace Lab3._4
{
    class Program
    {
        public delegate int SumDelegate(int[,] array);

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

         
            int[,] matrix = {
                { 2, 5, 7 },
                { -3, 8, 10 }
            };

            SumDelegate sumLambda = (int[,] arr) => 
            {
                int total = 0;
                foreach (int val in arr)
                    total += val;
                return total;
            };

            int resultLambda = sumLambda(matrix);
            Console.WriteLine($"Сума елементів (лямбда): {resultLambda}");

            SumDelegate sumAnonymous = delegate (int[,] arr)
            {
                int total = 0;
                foreach (int val in arr)
                    total += val;
                return total;
            };

            int resultAnon = sumAnonymous(matrix);
            Console.WriteLine($"Сума елементів (анонімний метод): {resultAnon}");

            Arithmetic arithmetic = new Arithmetic();

            EventListener listener = new EventListener(arithmetic);

            arithmetic.Add(2000000000, 2000000000);
            arithmetic.Multiply(50000, 60000);
            arithmetic.Subtract(10, 3);

            Console.ReadLine();
        }
    }
}
