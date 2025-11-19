using Lab3_5.DAL.Entities;

namespace Tests
{
    public class ExtraSkillTests
    {
        [Fact]
        public void Librarian_RideBicycle_Test()
        {
            Librarian librarian = new Librarian("Імʼя", "Прізвище");

            string result = librarian.RideBicycle();

            Assert.Contains("катається на велосипеді", result);
        }

        [Fact]
        public void Librarian_LearnOnline_Test()
        {
            Librarian librarian = new Librarian("Імʼя", "Прізвище");
            librarian.HasInternet = true;

            string result = librarian.LearnOnline();

            Assert.Contains("навчається онлайн", result);
        }

        [Fact]
        public void SoftwareDeveloper_RideBicycle_Test()
        {
            SoftwareDeveloper developer = new SoftwareDeveloper("Імʼя", "Прізвище");
            string result = developer.RideBicycle();

            Assert.StartsWith("Імʼя Прізвище", result);
            Assert.Contains("велосипеді", result);
        }

        [Fact]
        public void SoftwareDeveloper_LearnOnline_Test()
        {
            SoftwareDeveloper developer = new SoftwareDeveloper("Імʼя", "Прізвище");
            developer.HasInternet = true;
            string result = developer.LearnOnline();

            Assert.Contains("навчається онлайн", result);
        }
    }
}