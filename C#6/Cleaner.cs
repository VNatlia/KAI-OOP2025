using System.Text.RegularExpressions;

namespace TextLibrary
{
    public class Cleaner : ICleaner
    {
        public string Clean(string input)
        {
            string trimmed = input.Trim();
            return Regex.Replace(trimmed, @"\s+", " ");
        }
    }
}


 