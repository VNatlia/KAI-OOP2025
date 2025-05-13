using System;
using System.Linq;

namespace TextLibrary
{
    public class Line
    {
        private string content;

        public Line(string content)
        {
            this.content = content;
        }

        public string Content => content;

        public void SetContent(string newContent)
        {
            content = newContent;
        }

        public int GetLength()
        {
            return content.Length;
        }

        public double GetConsonantPercentage()
        {
            int totalLetters = content.Count(char.IsLetter);
            if (totalLetters == 0) return 0.0;

            int consonants = content
                .Where(char.IsLetter)
                .Count(c => !"aeiouyAEIOUY".Contains(c));

            return (consonants * 100.0) / totalLetters;
        }
    }
}

