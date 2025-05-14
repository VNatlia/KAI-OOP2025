using System;

namespace ExpressionLib
{
    public class InvalidArgumentException : Exception
    {
        public InvalidArgumentException(string message) : base(message) { }
    }

    public class Expression
    {
        private double a;
        private double c;
        private double d;

        public Expression(double a, double c, double d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
        }

        public double A => a;
        public double C => c;
        public double D => d;

        public void SetA(double value) => a = value;
        public void SetC(double value) => c = value;
        public void SetD(double value) => d = value;

        // Метод для логарифма
        private double CalculateLog(double x)
        {
            if (x <= 0)
                throw new InvalidArgumentException("Logarithm of non-positive number.");
            return Math.Log10(x);
        }

        // Основний метод обчислення виразу
        public double Calculate()
        {
            double denominator = a * a - 1;
            if (denominator == 0)
                throw new InvalidArgumentException("Division by zero.");

            double logPart = CalculateLog(d / 4.0);
            return (2 * c - logPart) / denominator;
        }
    }
}
