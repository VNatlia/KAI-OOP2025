namespace Lab3_5.DAL.Entities;

public partial class Student : Human
{
    public int Height { get; set; }
    public int Weight { get; set; }
    public string StudentID { get; set; }
    public string Passport { get; set; }

    public Student()
    {
        FirstName = "Імʼя";
        LastName = "Прізвище";
        Height = 160;
        Weight = 50;
        StudentID = "123456";
        Passport = "654321";
    }
    public Student(string fName, string lName, int height, int weight, string studId, string passport) : base (fName, lName)
    {
        Height = height;
        Weight = weight;
        StudentID = studId;
        Passport = passport;
    }
    public bool IsIdealWeight => (Height - 110) == Weight;

    public override string ToString()
        => $"{LastName} {FirstName} | Ріст: {Height}см | Вага: {Weight}кг | ID: {StudentID} | Паспорт: {Passport} | {(IsIdealWeight ? "Ідеальна вага!" : "Неідеальна")}";
}
