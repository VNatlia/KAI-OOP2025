using BLL;
using Lab3_3.DAL;
using Lab3_3.DAL.Entities;
using Lab3_3.DAL.Providers;
using Lab3_3.DAL.Interfaces;

namespace PL
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Лабораторна робота 3.3 (Варіант 7) ===\n");

            Console.WriteLine("Оберіть тип серіалізації:");
            Console.WriteLine("1 - JSON");
            Console.WriteLine("2 - XML");
            Console.WriteLine("3 - MemoryPack");
            Console.WriteLine("4 - Custom TXT");
            Console.Write("Ваш вибір: ");
            string? typeInput = Console.ReadLine();
            int.TryParse(typeInput, out int type);

            IDataProvider<Student> provider;
            string extension;

            switch (type)
            {
                case 2:
                    provider = new XmlProvider<Student>();
                    extension = ".xml";
                    break;
                case 3:
                    provider = new MemoryProvider<Student>();
                    extension = ".bin";
                    break;
                case 4:
                    provider = new CustomProvider<Student>();
                    extension = ".txt";
                    break;
                default:
                    provider = new JsonProvider<Student>();
                    extension = ".json";
                    break;
            }

            string filePath = "../../../Students" + extension;

            var context = new EntityContext<Student>(provider, filePath);
            var service = new EntityService(context);

            // Демонстрація додаткових сутностей
            var librarian = new Librarian("Tom", "Holland");
            var developer = new SoftwareDeveloper("Elon", "Musk");
            Console.WriteLine($"\n{librarian.RideBicycle()}");
            Console.WriteLine($"{developer.RideBicycle()}");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n=== МЕНЮ ===");
                Console.WriteLine("1. Додати студента");
                Console.WriteLine("2. Показати всіх студентів");
                Console.WriteLine("3. Видалити за StudentID");
                Console.WriteLine("4. Порахувати студентів з ідеальною вагою");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");
                int.TryParse(Console.ReadLine(), out int choice);

                try
                {
                    switch (choice)
                    {
                        case 1:
                            AddStudent(service);
                            break;
                        case 2:
                            ShowAll(service);
                            break;
                        case 3:
                            DeleteStudent(service);
                            break;
                        case 4:
                            CountIdeal(service);
                            break;
                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Невірний вибір, спробуйте ще раз!");
                            break;
                    }
                }
                catch (InvalidStudentDataException ex)
                {
                    Console.WriteLine($"⚠️ Помилка даних: {ex.Message}");
                }
                catch (DuplicateStudentException ex)
                {
                    Console.WriteLine($"⚠️ Дублікат: {ex.Message}");
                }
                catch (StudentNotFoundException ex)
                {
                    Console.WriteLine($"⚠️ Не знайдено: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Неочікувана помилка: {ex.Message}");
                }
            }
        }

        private static void AddStudent(EntityService service)
        {
            Console.Write("\nПрізвище: ");
            string lastName = Console.ReadLine() ?? "";
            Console.Write("Ім’я: ");
            string firstName = Console.ReadLine() ?? "";
            Console.Write("Ріст (см): ");
            int height = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Вага (кг): ");
            int weight = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("StudentID: ");
            string studentId = Console.ReadLine() ?? "";
            Console.Write("Паспорт: ");
            string passport = Console.ReadLine() ?? "";

            var student = new Student
            {
                LastName = lastName,
                FirstName = firstName,
                Height = height,
                Weight = weight,
                StudentID = studentId,
                Passport = passport
            };

            service.Add(student);
            Console.WriteLine("✅ Студента додано!");
        }

        private static void ShowAll(EntityService service)
        {
            var students = service.GetAll();
            if (students.Count == 0)
            {
                Console.WriteLine("\n❌ База пуста!");
                return;
            }

            Console.WriteLine("\n=== Усі студенти ===");
            foreach (var s in students)
                Console.WriteLine(s);
        }

        private static void DeleteStudent(EntityService service)
        {
            Console.Write("\nВведіть StudentID для видалення: ");
            string id = Console.ReadLine() ?? "";
            service.DeleteById(id);
            Console.WriteLine("✅ Студента (якщо існував) видалено.");
        }

        private static void CountIdeal(EntityService service)
        {
            int count = service.CountIdealWeight();
            Console.WriteLine($"\nКількість студентів з ідеальною вагою: {count}");
        }
    }
}
