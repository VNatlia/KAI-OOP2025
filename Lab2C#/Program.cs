namespace StringApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть рядок: ");
            string input = Console.ReadLine();


            StringClass myString = new StringClass(input);  
            StringClass copiedString = new StringClass(myString);  

            Console.WriteLine("Введений рядок: " + myString.GetValue());
            Console.WriteLine("Довжина рядка: " + myString.GetLength());
            Console.WriteLine("Обернений рядок: " + myString.ReverseString());
        }
    }
}