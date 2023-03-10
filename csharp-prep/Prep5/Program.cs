using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name1 = PromptUserName();
        int number1 = PromptUserNumber();
        int square1 = SquareNumber(number1);
        DisplayResult(square1, name1);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");  
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(int square, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }



}