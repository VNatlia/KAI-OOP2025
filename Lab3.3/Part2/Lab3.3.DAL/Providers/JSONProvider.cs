using System.Text.Json;
using Lab3_3.DAL.Interfaces;

namespace Lab3_3.DAL.Providers;

public class JsonProvider<T> : IDataProvider<T>
{
    public void Save(List<T> data, string path)
    {
        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, json);
    }

    public List<T> Load(string path)
    {
        if (!File.Exists(path)) return new();
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<T>>(json) ?? new();
    }
}
