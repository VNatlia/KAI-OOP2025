using System;

namespace StringLibrary
{
    public static class DisplayInformation

    {
        public static void ProcessString(StringBase obj)
        {
            Console.WriteLine($"Original Length: {obj.GetLength()}");
            Console.WriteLine($"Processed String: {obj.RemoveChar()}");
        }
    }
}
