using Lab3_3.DAL.Interfaces;

namespace Lab3_3.DAL.Providers;

public class CustomProvider<T> : IDataProvider<T>
{
    public void Save(List<T> data, string path)
    {
        using var writer = new StreamWriter(path);
        foreach (T item in data)
        {
            writer.WriteLine(item?.ToString());
        }
    }

    public List<T> Load(string path)
    {
        if (!File.Exists(path)) return new();
        return File.ReadAllLines(path).Select(line => default(T)!).ToList();
    }
}
