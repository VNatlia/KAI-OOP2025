using Lab3_3.DAL.Interfaces;

namespace Lab3_3.DAL;

public class EntityContext<T>
{
    private readonly IDataProvider<T> _provider;
    private readonly string _filePath;

    public EntityContext(IDataProvider<T> provider, string filePath)
    {
        _provider = provider;
        _filePath = filePath;
    }

    public void Save(List<T> data) => _provider.Save(data, _filePath);
    public List<T> Load() => _provider.Load(_filePath);
}
