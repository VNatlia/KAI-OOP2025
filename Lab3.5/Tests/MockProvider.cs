using Lab3_5.DAL.Interfaces;

namespace Tests;

public class MockProvider<T> : IDataProvider<T>
{
    private List<T> _data;
    public MockProvider(List<T> data) => _data = data;
    public void Save(List<T> data, string fileName) => _data = data;
    public List<T> Load(string fileName) => _data;
}
