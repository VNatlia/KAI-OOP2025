using Lab3_3.DAL;
using Lab3_3.DAL.Entities;

namespace BLL;

public class EntityService
{
    private readonly EntityContext<Student> _context;

    public EntityService(EntityContext<Student> context)
    {
        _context = context;
    }

    public void Add(Student student)
    {
        if (string.IsNullOrWhiteSpace(student.FirstName) ||
            string.IsNullOrWhiteSpace(student.LastName))
        {
            throw new InvalidStudentDataException("Ім’я або прізвище не можуть бути порожніми!");
        }

        if (student.Height <= 0 || student.Weight <= 0)
        {
            throw new InvalidStudentDataException("Ріст і вага повинні бути додатніми числами!");
        }

        var all = _context.Load();

        foreach (var s in all)
        {
            if (s.StudentID == student.StudentID)
            {
                throw new DuplicateStudentException($"Студент з ID {student.StudentID} вже існує!");
            }
        }

        all.Add(student);
        _context.Save(all);
    }

    public List<Student> GetAll() => _context.Load();

    public void DeleteById(string id)
    {
        var all = _context.Load();
        bool found = false;

        for (int i = 0; i < all.Count; i++)
        {
            if (all[i].StudentID == id)
            {
                all.RemoveAt(i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            throw new StudentNotFoundException($"Студента з ID {id} не знайдено!");
        }

        _context.Save(all);
    }

    public int CountIdealWeight()
    {
        var all = _context.Load();
        int count = 0;

        foreach (var s in all)
        {
            double ideal = s.Height - 110;
            if (Math.Abs(s.Weight - ideal) <= 3)
                count++;
        }

        return count;
    }
}
