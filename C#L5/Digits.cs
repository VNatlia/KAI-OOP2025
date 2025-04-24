namespace StringLibrary
{
    public class Digits : StringBase
    {
        public Digits(string val) : base(val) { }

        public override int GetLength() => value.Length;

        public override string RemoveChar()
        {
            return value.Replace("5", "");
        }
    }
}
