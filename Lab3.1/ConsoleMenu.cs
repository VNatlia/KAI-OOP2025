using System;
using System.IO;
using Lab3._1.Entities;
using Lab3._1.Files;

namespace ConsoleApp
{
    internal class ConsoleMenu
    {
        static void display(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Немає студентів для відображення.");
                return;
            }

            foreach (Student s in students)
            {
                Console.WriteLine($"{s.LastName} {s.FirstName}");
                Console.WriteLine("StudentID: " + s.StudentID.FullID);
                Console.WriteLine("Passport: " + s.Passport);
                Console.WriteLine("Height: " + s.Height);
                Console.WriteLine("Weight: " + s.Weight);
                
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Volynets", "Nataliia",  170, 60, new StudentID("KB", 123456), "AA121245"),
                new Student("Volynets", "Olena",     175, 90, new StudentID("KB", 344444), "BB676767"),
                new Student("Elon", "Musk",          180, 85, new StudentID("KB", 112233), "CC444455"), 
                new Student("Zendaya", "Mari",       176, 66, new StudentID("KB", 323232), "DD121212"), 
                new Student("Holland", "Tom",        180, 70, new StudentID("KB", 134110), "EE567890"),
                new Student("Challamet", "Timothee", 175, 70, new StudentID("KB", 203040), "FF600564") 
            };

            DataStream dataStream = new DataStream(students);
            dataStream.CreateFile("students.txt");
            Console.WriteLine("Файл створено!");
            string path = Path.GetFullPath("students.txt");
            Console.WriteLine("File path: " + path); 

            int idealCount = dataStream.ReadStudents("students.txt", null); 
            Console.WriteLine($"Кількість студентів з ідеальною вагою: {idealCount}\n");

            Student[] idealStudents = dataStream.ReturnIdealWeightStudents("students.txt");
            Console.WriteLine("Студенти з ідеальною вагою:");
            display(idealStudents);

          
            Librarian lib = new Librarian("Tom", "Holland");
            SoftwareDeveloper dev = new SoftwareDeveloper("Elon", "Musk");
            lib.RideBicycle();
            dev.RideBicycle();

           Console.WriteLine($"Librarian {lib.FirstName} {lib.LastName} can ride a bike");
            Console.WriteLine($"SoftwareDeveloper {dev.FirstName} {dev.LastName} can ride a bike");

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
