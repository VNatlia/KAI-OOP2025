using System.Xml.Serialization;
using Lab3_3.DAL.Interfaces;

namespace Lab3_3.DAL.Providers;

public class XmlProvider<T> : IDataProvider<T>
{
    public void Save(List<T> data, string path)
    {
        var serializer = new XmlSerializer(typeof(List<T>));
        using var fs = File.Create(path);
        serializer.Serialize(fs, data);
    }

    public List<T> Load(string path)
    {
        if (!File.Exists(path)) return new();
        var serializer = new XmlSerializer(typeof(List<T>));
        using var fs = File.OpenRead(path);
        return (List<T>?)serializer.Deserialize(fs) ?? new();
    }
}
