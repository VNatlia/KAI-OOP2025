namespace Lab3_5.DAL.Interfaces;

public interface IDataProvider<T>
{
    void Save(List<T> data, string path);
    List<T> Load(string path);
}
