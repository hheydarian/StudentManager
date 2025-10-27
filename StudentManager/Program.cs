using StudentManager2.Domain;
using StudentManager2.Services;

class Program
{
    static void Main()
    {
        IStudentService studentService = new StudentService();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Student Manager ===");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("1) Add Student");
            Console.WriteLine("2) List All");
            Console.WriteLine("3) List Passed");
            Console.WriteLine("4) Find by Name");
            Console.WriteLine("5) Remove by Name");

            Console.WriteLine("0) Exit");
            Console.WriteLine("Select: _");
            Console.ResetColor();

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine() ?? "";
                    Console.WriteLine("Enter Age:");
                    int age = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Enter Score:");
                    decimal score = decimal.Parse(Console.ReadLine() ?? "0");
                    studentService.Add(new Student(name, age, score));
                    Console.WriteLine("Student added successfuly!");
                    break;
                case "2":
                    foreach (var s in studentService.GetAll())
                    {
                        s.PrintInfo();
                    }
                    break;
                case "3":
                    foreach (var s in studentService.GetPassed())
                    {
                        s.PrintInfo();
                    }
                    break;
                case "4":
                    Console.WriteLine("Enter Name:");
                    var found = studentService.FindByName(Console.ReadLine() ?? "");
                    if (found != null)
                    {
                        found.PrintInfo();
                    }
                    else
                    {
                        Console.WriteLine("Not Found!");
                    }
                    break;
                case "5":
                    Console.WriteLine("Enter Name:");
                    bool removed = studentService.RemoveByName(Console.ReadLine() ?? "");
                    Console.WriteLine(removed ? "Removed" : "Not Found");
                    break;

                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid Choise");
                    break;
            }
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}