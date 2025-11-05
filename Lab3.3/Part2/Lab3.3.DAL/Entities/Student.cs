using MemoryPack;
using System.Xml.Serialization;

namespace Lab3_3.DAL.Entities;

[MemoryPackable]
public partial class Student
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public string StudentID { get; set; }
    public string Passport { get; set; }

    [XmlIgnore]
    public bool IsIdealWeight => (Height - 110) == Weight;

    public Student() { }

    public override string ToString()
        => $"{LastName} {FirstName} | Ріст: {Height}см | Вага: {Weight}кг | ID: {StudentID} | Паспорт: {Passport} | {(IsIdealWeight ? "✅ Ідеальна вага" : "❌ Неідеальна")}";
}
