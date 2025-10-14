using System;

namespace Lab3._1.Entities;

public class SoftwareDeveloper : Human, IBikeRider
{

        public SoftwareDeveloper(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string RideBicycle()
        {
            return $"{FirstName} {LastName}";
        }
}
