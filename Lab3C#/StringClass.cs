namespace StringApp
{
    public class StringClass
    {
        private string value;

        public StringClass() //порожн. конструктор
        {
            value = "";
        }

        public StringClass(string val) //конструкт. з параметром
        {
            value = val;
        }

        public StringClass(StringClass other) //конструкт. копіювання
        {
            value = other.value;
        }
        // Метод з аргументами за замовчуванням
        public void PrintString(string prefix = "Value: ")
        {
            Console.WriteLine(prefix + value);
        }

        public static StringClass operator +(StringClass s1, StringClass s2) //перевантаж. оператора+
        {
            return new StringClass(s1.value + s2.value);
        }

        public static StringClass operator -(StringClass s, char ch) //перевантаж. оператора -
        {
            return new StringClass(s.value.Replace(ch.ToString(), ""));
        }
    
        public int GetLength()
        {
            return value.Length;
        }

        public string GetValue()
        {
            return value;
        }
    }
}
