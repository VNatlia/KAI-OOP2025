using Lab3_5.BLL;
using Lab3_5.DAL;
using Lab3_5.DAL.Entities;

namespace Tests
{
    public class ExeptionTests
    {
        private EntityService MockService(List<Student>? data = null)
        {
            MockProvider<Student> mockProvider = new MockProvider<Student>(data ?? new());
            EntityContext<Student> ctx = new EntityContext<Student>(mockProvider, "mock");
            return new EntityService(ctx);
        }

        [Fact]
        public void Add_Duplicate_Student_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321"), 
            };
            EntityService service = MockService(students);
            Student duplicate = new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321");
            
            Assert.Throws<DuplicateStudentException>(() => service.Add(duplicate));
        }

        [Fact]
        public void DeleteById_Not_Existing_Student_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321"), 
            };
            EntityService service = MockService(students);
            
            Assert.Throws<StudentNotFoundException>(() => service.DeleteById("123457"));
        }
        
        [Fact]
        public void UpdateWeight_Not_Existing_Student_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321"), 
            };
            EntityService service = MockService(students);
            
            Assert.Throws<StudentNotFoundException>(() => service.UpdateWeight("123457", 90));
        }

        [Fact]
        public void GainWeight_Not_Existing_Student_Test()
        {
            List<Student> students = new List<Student>
            {
                new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321"), 
            };
            EntityService service = MockService(students);
            
            Assert.Throws<StudentNotFoundException>(() => service.GainWeight("123457", 10));
        }
    }
}