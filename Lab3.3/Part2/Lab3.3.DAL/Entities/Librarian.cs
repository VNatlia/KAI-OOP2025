using System;
using Lab3_3.DAL.Interfaces;

namespace Lab3_3.DAL.Entities;

public class Librarian : Human, IBikeRider
{
    public Librarian() {}
    public Librarian(string first, string last) : base(first, last) {}
    public string RideBicycle() => $"{FirstName} {LastName} катається на велосипеді";
}
