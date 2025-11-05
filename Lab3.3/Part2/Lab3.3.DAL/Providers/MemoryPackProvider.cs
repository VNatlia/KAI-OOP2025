using MemoryPack;
using Lab3_3.DAL.Interfaces;

namespace Lab3_3.DAL.Providers;

public class MemoryProvider<T> : IDataProvider<T>
{
    public void Save(List<T> data, string path)
    {
        byte[] bytes = MemoryPackSerializer.Serialize(data);
        File.WriteAllBytes(path, bytes);
    }

    public List<T> Load(string path)
    {
        if (!File.Exists(path)) return new();
        byte[] bytes = File.ReadAllBytes(path);
        return MemoryPackSerializer.Deserialize<List<T>>(bytes) ?? new();
    }
}
