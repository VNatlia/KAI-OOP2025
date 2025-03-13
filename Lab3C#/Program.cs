namespace StringApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть рядок для S2: ");
            string input2 = Console.ReadLine();

            Console.Write("Введіть рядок для S3: ");
            string input3 = Console.ReadLine();

            StringClass S2 = new StringClass(val: input2); //val: - іменований аргумент 
            StringClass S3 = new StringClass(input3);


            // Вирахування символу # (перевантаж оператор -)
            S2 = S2 - '#';
            // Додавання S2 + S3 (перевантаж. оператор +)
            StringClass S1 = S2 + S3;

            Console.WriteLine("\nРезультати:");
            Console.WriteLine("S1 (S2 + S3): " + S1.GetValue());
            Console.WriteLine("Довжина S1: " + S1.GetLength());
        }
    }
}