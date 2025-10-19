public class Person
{
    private  string _name = string.Empty;
    private int _age;
    public string Name
    {
        get => _name;

        set => _name = value ?? throw new ArgumentNullException(nameof(value), "Name cannot empty.");
    }
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentOutOfRangeException(nameof(Age), "Age cannot < 0 or > 120");
            }
            _age = value;
        }
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }


}
