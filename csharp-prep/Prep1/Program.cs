using System;

class Program
{
    private const string V = "F";

    static void Main(string[] args)
    {
        Console.Write("What is your first name?: ");
        string name1 = Console.ReadLine();
        Console.WriteLine("What is your last name?: ");
        String name2 = Console.ReadLine();
        Console.WriteLine($"Your name is {name2}, {name1} {name2}.");
    }
}