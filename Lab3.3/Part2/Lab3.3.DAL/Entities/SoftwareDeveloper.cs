using System;
using Lab3_3.DAL.Interfaces;

namespace Lab3_3.DAL.Entities;

public class SoftwareDeveloper : Human, IBikeRider
{
    public SoftwareDeveloper() {}
    public SoftwareDeveloper(string first, string last) : base(first, last) {}
    public string RideBicycle() => $"{FirstName} {LastName} катається на велосипеді";
}
