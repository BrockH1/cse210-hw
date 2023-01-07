using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "A";
        Console.Write("What is your percentage grade?: ");
        string grade = Console.ReadLine();
        int numGrade = int.Parse(grade);
        if (numGrade >= 90)
        {
            letter = "A";
        }
        else if (numGrade >= 80)
        {
            letter = "B";
        }
        else if (numGrade >= 70)
        {
           letter = "C";
        }
        else if (numGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You received a {letter}");
        if (letter == "F" || letter == "D")
        {
            Console.WriteLine("You failed. Womp womp.");
        }
        else
        {
            Console.WriteLine("You passed! Yaaaaaay!");
        }
    }
    }