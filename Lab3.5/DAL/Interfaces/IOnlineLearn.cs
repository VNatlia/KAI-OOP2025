namespace Lab3_5.DAL.Interfaces;

public interface IOnlineLearn
{
    bool HasInternet { get; set; }
    string LearnOnline();
}
