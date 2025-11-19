using Lab3_5.DAL.Interfaces;

namespace Lab3_5.DAL.Entities;

public class Librarian : Human, IBikeRider, IOnlineLearn
{
    public Librarian() {}
    public Librarian(string first, string last) : base(first, last) {}
    public bool HasInternet { get; set; }

    public string LearnOnline()
    {
        return HasInternet ? $"{FirstName} {LastName} навчається онлайн" : $"{FirstName} {LastName} не має інтернет зʼєднання";
    }
    public string RideBicycle() => $"{FirstName} {LastName} катається на велосипеді";
}
