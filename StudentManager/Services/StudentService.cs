using StudentManager2.Domain;

namespace StudentManager2.Services;

public class StudentService : IStudentService
{
    private readonly List<Student> _students = new();
    public void Add(Student s)
    {
        _students.Add(s);
    }

    public Student? FindByName(string name)
    {
        return _students.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public List<Student> GetAll()
    {
        return _students.ToList();
    }

    public List<Student> GetPassed()
    {
        return _students.Where(x => x.IsPassed).ToList();
    }

    public bool RemoveByName(string name)
    {
        var found = _students.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (found != null)
        {
            _students.Remove(found);
            return true;
        }
        return false;
    }
}
