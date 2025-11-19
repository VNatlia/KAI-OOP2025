using Lab3_5.DAL;
using Lab3_5.DAL.Entities;
using Lab3_5.DAL.Providers;
using Lab3_5.DAL.Interfaces;
using Lab3_5.BLL;

namespace PL
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            IDataProvider<Student> provider = new JsonProvider<Student>();
            string filePath = "../../../Students.json";

            EntityContext<Student> context = new EntityContext<Student>(provider, filePath);
            EntityService service = new EntityService(context);

            Console.WriteLine("Демонстрація додаткових вмінь бібліотекаря\n");
            Librarian lib = new Librarian("Едвард", "Калін");
            Console.WriteLine(lib.RideBicycle());
            Console.WriteLine(lib.LearnOnline());
            lib.HasInternet = true;
            Console.WriteLine(lib.LearnOnline());
            Console.WriteLine("");

            Console.WriteLine("Демонстрація додаткових вмінь розробника\n");
            SoftwareDeveloper dev = new SoftwareDeveloper("Наталія", "Волинець");
            Console.WriteLine(dev.RideBicycle());
            Console.WriteLine(dev.LearnOnline());
            dev.HasInternet = true;
            Console.WriteLine(dev.LearnOnline());

            service.IdealWeightReached += (sender, e) =>
            {
                Student s = e.Student;
                Console.WriteLine($"\nІвент спрацював: {s.FirstName} {s.LastName} досяг ідеальної ваги: {s.Weight} кг");
            };

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n    МЕНЮ     ");
                Console.WriteLine("1. Додати студента");
                Console.WriteLine("2. Показати всіх студентів");
                Console.WriteLine("3. Видалити за StudentID");
                Console.WriteLine("4. Порахувати студентів з ідеальною вагою");
                Console.WriteLine("5. Набрати вагу студента");
                Console.WriteLine("6. Скинути вагу студента");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");
                int.TryParse(Console.ReadLine(), out int choice);

                try
                {
                    switch (choice)
                    {
                        case 1: AddStudent(service); break;
                        case 2: ShowAll(service); break;
                        case 3: DeleteStudent(service); break;
                        case 4: CountIdeal(service); break;
                        case 5: GainWeight(service); break;
                        case 6: LoseWeight(service); break;
                        case 0: exit = true; break;
                        default: Console.WriteLine("Невірний вибір!"); break;
                    }
                }
                catch (StudentNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (DuplicateStudentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidStudentDataException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void AddStudent(EntityService service)
        {
            Console.Write("\nПрізвище: ");
            string lastName = Console.ReadLine() ?? "";
            Console.Write("Ім’я: ");
            string firstName = Console.ReadLine() ?? "";

            int height;
            while (true)
            {
                Console.Write("Ріст (см): ");
                if (int.TryParse(Console.ReadLine(), out height) && height > 0)
                    break;
                Console.WriteLine("Будь ласка, введіть правильний додатний цілий ріст.");
            }

            int weight;
            while (true)
            {
                Console.Write("Вага (кг): ");
                if (int.TryParse(Console.ReadLine(), out weight) && weight > 0)
                    break;
                Console.WriteLine("Будь ласка, введіть правильну додатню вагу.");
            }

            Console.Write("StudentID: ");
            string studentId = Console.ReadLine() ?? "";
            Console.Write("Паспорт: ");
            string passport = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(studentId) ||
                string.IsNullOrWhiteSpace(passport))
            {
                throw new InvalidStudentDataException("Дані студента не можуть бути пустими");
            }

            Student student = new Student (firstName, lastName, height, weight, studentId, passport);

            service.Add(student);
            Console.WriteLine("Студента додано");
        }


        private static void ShowAll(EntityService service)
        {
            List<Student> students = service.GetAll();
            if (students.Count == 0)
            {
                Console.WriteLine("\nФайл пустий");
                return;
            }

            Console.WriteLine("\n   Усі студенти ");
            foreach (Student s in students)
            {
                string status = s.IsIdealWeight ? "Ідеальна вага!" : "Неідеальна";
                Console.WriteLine($"{s.LastName} {s.FirstName} | Ріст: {s.Height}см | Вага: {s.Weight}кг | ID: {s.StudentID} | Паспорт: {s.Passport} | {status}");
            }
        }

        private static void DeleteStudent(EntityService service)
        {
            Console.Write("\nВведіть StudentID для видалення: ");
            string id = Console.ReadLine() ?? "";
            service.DeleteById(id);
            Console.WriteLine("Студента видалено.");
        }

        private static void CountIdeal(EntityService service)
        {
            Console.WriteLine($"Студентів з ідеальною вагою: {service.CountIdealWeight()}");
        }

        private static void GainWeight(EntityService service)
        {
            Console.Write("\nВведіть StudentID: ");
            string id = Console.ReadLine() ?? "";
            Console.Write("На скільки кг набрати вагу? ");
            int amount = int.Parse(Console.ReadLine());
            service.GainWeight(id, amount);
            Console.WriteLine("Вага змінена.");
        }

        private static void LoseWeight(EntityService service)
        {
            Console.Write("\nВведіть StudentID: ");
            string id = Console.ReadLine() ?? "";
            Console.Write("На скільки кг зменшити вагу? ");
            int amount = int.Parse(Console.ReadLine());
            service.LoseWeight(id, amount);
            Console.WriteLine("Вага змінена.");
        }
    }
}
