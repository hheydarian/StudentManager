namespace StudentManager2.Domain;

public class Student : Person
{
    private decimal _score;
    public decimal Score
    {
        get => _score;
        set
        {
            if (value < 0 || value > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(Score), "Score cannot < 0 or > 20");
            }
            _score = value;
        }
    }
    public Student(string name, int age, decimal score) : base(name, age)
    {
        Score = score;
    }
}
