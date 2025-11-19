using Lab3_5.DAL;
using Lab3_5.DAL.Entities;

namespace Lab3_5.BLL
{
    public class EntityService
    {
        private readonly EntityContext<Student> _context;

        public event EventHandler<StudentEventArgs>? IdealWeightReached;

        public EntityService(EntityContext<Student> context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            List<Student> all = _context.Load();

            if (all.Any(s => s.StudentID == student.StudentID))
                throw new DuplicateStudentException($"Студент з ID {student.StudentID} вже існує!");

            all.Add(student);
            _context.Save(all);
        }

        public List<Student> GetAll() => _context.Load();

        public void DeleteById(string id)
        {
            List<Student> all = _context.Load();
            Student student = all.FirstOrDefault(s => s.StudentID == id);

            if (student == null)
                throw new StudentNotFoundException($"Студента з ID {id} не знайдено!");

            all.Remove(student);
            _context.Save(all);
        }

        private void CheckIdeal(Student student)
        {
            if (student.IsIdealWeight)
                IdealWeightReached?.Invoke(this, new StudentEventArgs(student));
        }

        public void UpdateWeight(string studentId, int newWeight)
        {
            List<Student> all = _context.Load();
            Student student = all.FirstOrDefault(s => s.StudentID == studentId);
            if (student == null)
                throw new StudentNotFoundException($"Студента з ID {studentId} не знайдено!");

            student.Weight = newWeight;
            CheckIdeal(student);
            _context.Save(all);
        }

        public void GainWeight(string studentId, int amount)
        {
            List<Student> all = _context.Load();
            Student student = all.FirstOrDefault(s => s.StudentID == studentId);
            if (student == null)
                throw new StudentNotFoundException($"Студента з ID {studentId} не знайдено!");

            UpdateWeight(studentId, student.Weight + amount);
        }

        public void LoseWeight(string studentId, int amount)
        {
            List<Student> all = _context.Load();
            Student student = all.FirstOrDefault(s => s.StudentID == studentId);
            if (student == null)
                throw new StudentNotFoundException($"Студента з ID {studentId} не знайдено!");

            UpdateWeight(studentId, student.Weight - amount);
        }

        public int CountIdealWeight()
        {
            List<Student> all = _context.Load();
            int count = 0;

            foreach (Student s in all)
            {
                double ideal = s.Height - 110;
                if (Math.Abs(s.Weight - ideal) <= 3)
                    count++;
            }

            return count;
        }
    }
}
