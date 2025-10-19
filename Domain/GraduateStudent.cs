namespace StudentManager2.Domain;

public class GraduateStudent : Student
{
    private string _title = string.Empty;
    private string Title
    {
        get => _title;
        set => _title = value ?? throw new ArgumentNullException(nameof(value), "Title cannot empty.");
    }
    public GraduateStudent(string name, int age, decimal score, string title) : base(name, age, score)
    {
        Title = title;
    }
}
