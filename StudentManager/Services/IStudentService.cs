using StudentManager2.Domain;

namespace StudentManager2.Services;

public interface IStudentService
{
    public List<Student> students();
    public void Add();
    public void GetAll();
    public void Delete();
    public void IsPassed();
}
