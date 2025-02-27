
namespace StringApp
{
    class StringClass
    {
        public string value; 
        public StringClass(string val) 
        {
            value = val;
        }

        public int GetLength()
        {
            return value.Length;  
        }

        // Метод для обернення рядка
        public string ReverseString()
        {
            char[] charArray = value.ToCharArray(); 
            Array.Reverse(charArray); 
            return new string(charArray);
        }

        // Метод для отримання рядка
        public string GetValue()
        {
            return value;
        }
    }
}
