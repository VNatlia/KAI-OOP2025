using System;
using System.IO;
using Lab3._1.Entities;

namespace Lab3._1.Files
{


    public class DataStream
    {
        private Student[] students;
        public DataStream(Student[] students)
        {
            this.students = students;
        }

        public void CreateFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Student s in students)
                {
                    if (!s.StudentID.IsValidStudentID())
                    {
                        throw new Exception("Invalid student ID!");
                    }

                    writer.WriteLine($"Student {s.FirstName}{s.LastName}");
                    writer.WriteLine("{");
                    writer.WriteLine($"\"firstname\": \"{s.FirstName}\",");
                    writer.WriteLine($"\"lastname\": \"{s.LastName}\",");
                    writer.WriteLine($"\"studentId\": \"{s.StudentID.FullID}\",");
                    writer.WriteLine($"\"passport\": \"{s.Passport}\",");
                    writer.WriteLine($"\"height\": {s.Height},");
                    writer.WriteLine($"\"weight\": {s.Weight},");
                    writer.WriteLine("}");
                }
            }
        }

        public int ReadStudents(string fileName, Student[] studentsArray)
        {
            int Count = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                string firstName = "", lastName = "";
                int height = 0, weight = 0, course = 0;
                StudentID id = null;
                string passport = "";

                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();

                    if (line.StartsWith("\"firstname\""))
                        firstName = line.Split('"')[3];
                    else if (line.StartsWith("\"lastname\""))
                        lastName = line.Split('"')[3];
                    else if (line.StartsWith("\"studentId\""))
                    {
                        string full = line.Split('"')[3];
                        id = new StudentID(full.Substring(0, 2), int.Parse(full.Substring(2)));
                    }
                    else if (line.StartsWith("\"passport\""))
                        passport = line.Split('"')[3];
                    else if (line.StartsWith("\"height\""))
                        height = int.Parse(line.Split(':')[1].Trim().TrimEnd(','));
                    else if (line.StartsWith("\"weight\""))
                        weight = int.Parse(line.Split(':')[1].Trim().TrimEnd(','));
                    

                    if (line == "}") 
                    {

                        if (id != null) 
                        {

                            bool isIdeal = (height - 110) == weight;
                            if (isIdeal)
                            {
                                if (studentsArray != null)
                                {
                                    if (Count < studentsArray.Length)
                                    {
                                        studentsArray[Count] = new Student(lastName, firstName, height, weight, id, passport);
                                    }
                                }
                                Count++;
                            }
                        }
                        
                        firstName = lastName = "";
                        height = weight = 0;
                        id = null;
                        passport = "";
                    }
                }
            }

            return Count;
        }

        public Student[] ReturnIdealWeightStudents(string fileName)
        {
            int count = ReadStudents(fileName, null);
            if (count == 0) return new Student[0];
            Student[] studentArray = new Student[count];
            ReadStudents(fileName, studentArray);
            return studentArray;
        }
    }
}

