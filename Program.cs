class Program
{
    static void Main()
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
        Console.WriteLine("6) Demo Polymorphism");
        Console.WriteLine("0) Exit");
        Console.WriteLine("Select: _");
        Console.ResetColor();

    }
}