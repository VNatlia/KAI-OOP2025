using System;

namespace Lab3._1.Entities;

public class Librarian : Human, IBikeRider
{

        public Librarian(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string RideBicycle()
        {
            return $"{FirstName} {LastName}";
        }
}
