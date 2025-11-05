using System.Text.Json;
using System.Xml.Serialization;
using MemoryPack;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Vector[] array =
        {
                new("Red", 3, 4),
                new("Green", 0, 5),
                new("Blue", 1, 2)
            };

        Console.WriteLine("=== Початкові дані ===");
        foreach (Vector v in array)
            Console.WriteLine(v);

        Directory.CreateDirectory("../../../../Results");

        // ✅ JSON
        string jsonPath = "../../../../Results/vectors.json";
        File.WriteAllText(jsonPath, JsonSerializer.Serialize(array, new JsonSerializerOptions { WriteIndented = true }));

        Vector[] fromJson = JsonSerializer.Deserialize<Vector[]>(File.ReadAllText(jsonPath))!;
        Console.WriteLine($"\nJSON saved {jsonPath.Substring(12)}");
        foreach (Vector v in fromJson) Console.WriteLine(v);

        // ✅ XML
        string xmlPath = "../../../../Results/vectors.xml";
        var xml = new XmlSerializer(typeof(Vector[]));
        using (var fs = File.Create(xmlPath))
            xml.Serialize(fs, array);
        Console.WriteLine($"\nXML saved {xmlPath.Substring(12)}");

        using var fs2 = File.OpenRead(xmlPath);
        var fromXml = (Vector[]?)xml.Deserialize(fs2);
        foreach (Vector v in fromXml!) Console.WriteLine(v);

        // ✅ MemoryPack
        string memPath = "../../../../Results/vectors.bin";
        File.WriteAllBytes(memPath, MemoryPackSerializer.Serialize(array));

        var fromMemoryPack = MemoryPackSerializer.Deserialize<Vector[]>(File.ReadAllBytes(memPath))!;
        Console.WriteLine($"\nMemoryPack saved {memPath.Substring(12)}");
        foreach (Vector v in fromMemoryPack) Console.WriteLine(v);

        // ✅ Custom TXT
        string customPath = "../../../../Results/vectors_custom.txt";
        using (var writer = new StreamWriter(customPath))
        {
            foreach (Vector v in array)
                writer.WriteLine($"{v.Color}|{v.X}|{v.Y}");
        }
        Console.WriteLine($"\nCustomText saved {customPath.Substring(12)}");

        var customList = new List<Vector>();
        foreach (string line in File.ReadAllLines(customPath))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
                customList.Add(new Vector(parts[0], double.Parse(parts[1]), double.Parse(parts[2])));
        }
        foreach (Vector v in customList) Console.WriteLine(v);

        // ✅ Порівняння
        var list = new List<Vector>(array);
        string listJson = JsonSerializer.Serialize(list);

        Console.WriteLine($"\n=== Compare ===");
        Console.WriteLine($"Array JSON bytes: {File.ReadAllBytes(jsonPath).Length}");
        Console.WriteLine($"List JSON bytes: {System.Text.Encoding.UTF8.GetBytes(listJson).Length}");
        Console.WriteLine($"MemoryPack bytes: {File.ReadAllBytes(memPath).Length}");
    }
}