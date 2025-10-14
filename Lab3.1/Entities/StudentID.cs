using System;

namespace Lab3._1.Entities;
using System.Text.RegularExpressions;

public class StudentID
{
public string IDletters;
        public int IDnumbers;
        public string FullID;

        public StudentID(string letters, int numbers)
        {
            IDletters = letters;
            IDnumbers = numbers;
            FullID = letters + numbers.ToString("D6"); 
        }

          public bool IsValidStudentID()
        {
            return Regex.IsMatch(FullID, @"^[A-Z]{2}\d{6}$");
        }
}
