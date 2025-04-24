namespace StringLibrary
{
    public class Letters : StringBase
    {
        public Letters(string val) : base(val) { }

        public override int GetLength() => value.Length;

        public override string RemoveChar()
        {
            return value.Replace("a", "").Replace("A", "");
        }
    }
}
