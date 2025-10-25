using System;

namespace Lab3._4;

public class Arithmetic
{
        public event EventHandler<OverflowEventArgs> OverflowOccurred;

        public int Add(int a, int b)
        {
            try
            {
                checked
                {
                    int result = a + b;
                    Console.WriteLine($"Результат додавання: {result}");
                    return result;
                }
            }
            catch (OverflowException)
            {
                OnOverflowOccurred(new OverflowEventArgs("Переповнення при додаванні!"));
                return 0;
            }
        }
        public int Subtract(int a, int b)
        {
            try
            {
                checked
                {
                    int result = a - b;
                    Console.WriteLine($"Результат віднімання: {result}");
                    return result;
                }
            }
            catch (OverflowException)
            {
                OnOverflowOccurred(new OverflowEventArgs("Переповнення при відніманні!"));
                return 0;
            }
        }
        public int Multiply(int a, int b)
        {
            try
            {
                checked
                {
                    int result = a * b;
                    Console.WriteLine($"Результат множення: {result}");
                    return result;
                }
            }
            catch (OverflowException)
            {
                OnOverflowOccurred(new OverflowEventArgs("Переповнення при множенні!"));
                return 0;
            }
        }
        protected virtual void OnOverflowOccurred(OverflowEventArgs e)
        {
            OverflowOccurred?.Invoke(this, e);
        }
    }


