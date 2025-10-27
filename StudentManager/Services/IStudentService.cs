using StudentManager2.Domain;

namespace StudentManager2.Services;

public interface IStudentService
{
    void Add(Student s);
    bool RemoveByName(string name);
    Student? FindByName(string name);
    List<Student> GetAll();
    List<Student> GetPassed();
}
