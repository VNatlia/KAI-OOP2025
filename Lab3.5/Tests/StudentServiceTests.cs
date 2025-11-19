using Lab3_5.BLL;
using Lab3_5.DAL;
using Lab3_5.DAL.Entities;

namespace Tests
{
    public class StudentServiceTests
    {
        private EntityService MockService(List<Student>? data = null)
        {
            MockProvider<Student> mockProvider = new MockProvider<Student>(data ?? new());
            EntityContext<Student> ctx = new EntityContext<Student>(mockProvider, "mock");
            return new EntityService(ctx);
        }

        [Fact]
        public void Get_All_Students_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя1", "Прізвище1", 180, 80, "123456", "654321"),
                new Student("Імʼя2", "Прізвище2", 180, 70, "123457", "654322"),
                new Student("Імʼя3", "Прізвище3", 180, 60, "123458", "654323")
            };
            EntityService service = MockService(students);

            List<Student> all = service.GetAll();
            int result = all.Count;

            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_NewStudent_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321"),
            };
            EntityService service = MockService(students);
            Student newStudent = new Student("Новий", "Студент", 170, 60, "321123", "543211");

            service.Add(newStudent);
            List<Student> all = service.GetAll();

            Assert.Equal(2, all.Count);
            Assert.Contains(all, s => s.StudentID == "321123");
        }

        [Fact]
        public void UpdateWeight_Existing_Student_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321"),
            };
            EntityService service = MockService(students);

            service.UpdateWeight("123456", 80);
            Student updatedStudent = service.GetAll().First(s => s.StudentID == "123456");

            Assert.Equal(80, updatedStudent.Weight);
        }

        [Fact]
        public void UpdateWeight_ToIdeal_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя", "Прізвище", 175, 70, "123456", "654321"),
            };
            EntityService service = MockService(students);
            Student eventStudent = null;
            service.IdealWeightReached += (sender, e) => eventStudent = e.Student;

            service.UpdateWeight("123456", 65);

            Assert.NotNull(eventStudent);
            Assert.Equal("123456", eventStudent.StudentID);
        }

        [Fact]
        public void CountIdealWeight_Student_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя1", "Прізвище1", 170, 80, "123456", "654321"),
                new Student("Імʼя2", "Прізвище2", 180, 70, "123457", "654322"),
                new Student("Імʼя3", "Прізвище3", 165, 55, "123458", "654323")
            };
            EntityService service = MockService(students);

            int count = service.CountIdealWeight();

            Assert.Equal(2, count);
        }

        [Fact]
        public void GainWeight_Existing_Student_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321")
            };
            EntityService service = MockService(students);

            service.GainWeight("123456", 5);
            Student updatedStudent = service.GetAll().First(s => s.StudentID == "123456");

            Assert.Equal(75, updatedStudent.Weight);
        }

        [Fact]
        public void LoseWeight_Existing_Student_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321")
            };
            EntityService service = MockService(students);

            service.LoseWeight("123456", 5);
            Student updatedStudent = service.GetAll().First(s => s.StudentID == "123456");

            Assert.Equal(65, updatedStudent.Weight);
        }
    }
}