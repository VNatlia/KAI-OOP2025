using Lab3_5.DAL.Entities;

namespace Tests
{
    public class StudentTests
    {
        [Fact]
        public void IsIdealWeight_Succsess_Test()
        {
            Student student = new Student("Імʼя", "Прізвище", 180, 70, "123456", "654321");
            Assert.True(student.IsIdealWeight);
        }

        [Fact]
        public void Create_Student_Test()
        {
            Student student = new Student();
            Assert.Equal("123456", student.StudentID);
        }

        [Fact]
        public void IsIdealWeight_Failed_Test()
        {
            Student student = new Student("Імʼя", "Прізвище", 180, 75, "123456", "654321");
            Assert.False(student.IsIdealWeight);
        }

        [Fact]
        public void ToString_Test()
        {
            Student student = new Student("Студент", "Прізвище", 180, 70, "123456", "654321");

            string result = student.ToString();

            Assert.Contains("Прізвище Студент", result);
            Assert.Contains("Ріст: 180см", result);
            Assert.Contains("Вага: 70кг", result);
            Assert.Contains("Ідеальна вага!", result);
        }
    }
}