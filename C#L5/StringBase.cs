namespace StringLibrary
{
    public abstract class StringBase
    {
        protected string value;

        public StringBase(string val)
        {
            value = val;
        }

        public string Value => value;

        public abstract int GetLength();
        public abstract string RemoveChar();
    }
}
