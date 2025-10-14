using System;

namespace Lab3._1.Entities;

public class Student : Human, IBikeRider
    {
        private StudentID _studentID;
        public StudentID StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }


        public string Passport { get; set; } 
        public int Height { get; set; }      
        public int Weight { get; set; }      
        

        public Student(string lastName, string firstName, int height, int weight, StudentID studentID, string passport)
            : base(firstName, lastName)
        {
            _studentID = studentID;
            Passport = passport;
            Height = height;
            Weight = weight;
           
        }

     public string RideBicycle()
        {
            return $"{FirstName} {LastName}";
        }

        public bool IsIdealWeight()
        {
            return (Height - 110) == Weight;
        }
    }
