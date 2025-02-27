namespace StringApp
{
    public class StringClass
    {
        private string value; //приватне поле класу 

        public StringClass()
        { value = ""; }    
        public StringClass(string val)
        { value = val; } 
        public StringClass(StringClass other)
        { value = other.value; }

        ~StringClass()
        {

        }

        public int GetLength()
        {
            return value.Length;
        }

        public string ReverseString()
        {
            char[] charArray = value.ToCharArray(); 
            Array.Reverse(charArray); 
            return new string(charArray);  
        }
        public string GetValue() 
        {
            return value;
        }

    }
}