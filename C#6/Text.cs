using System;
using System.Collections.Generic;
using System.Linq;

namespace TextLibrary
{
    public class Text
    {
        private List<Line> lines = new();

        public void AddLine(Line line)
        {
            lines.Add(line);
        }

        public void RemoveLine(int index)
        {
            if (index >= 0 && index < lines.Count)
                lines.RemoveAt(index);
        }

        public void Clear()
        {
            lines.Clear();
        }

        public int GetShortestLineLength()
        {
            if (lines.Count == 0) return 0;
            return lines.Min(l => l.GetLength());
        }

        public double GetTotalConsonantPercentage()
        {
            if (lines.Count == 0) return 0.0;
            return lines.Average(l => l.GetConsonantPercentage());
        }

        public void TrimSpaces(ICleaner cleaner)
        {
            foreach (var line in lines)
            {
                line.SetContent(cleaner.Clean(line.Content));
            }
        }

        public IEnumerable<string> GetLines()
        {
            return lines.Select(l => l.Content);
        }
    }
}
