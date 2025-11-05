using System;

namespace Lab3_3.DAL.Entities;

public abstract class Human
{
    public string FirstName { get; set; }
    public string LastName  { get; set; }
    protected Human() {}
    protected Human(string first, string last)
    {
        FirstName = first;
        LastName = last;
    }
}
