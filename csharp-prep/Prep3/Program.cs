using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "Yes";
        while (answer == "Yes")
        {
            Console.Write("What is the magic number?: ");
            string number = Console.ReadLine();
            int input = int.Parse(number);
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);
            while (input != magicNumber)
            {
                while (input < magicNumber)
                {
                    Console.Write("Higher. Try again: ");
                    input = int.Parse(Console.ReadLine());
                }
                while (input > magicNumber)
                {
                Console.Write("Lower. Try again: ");
                input = int.Parse(Console.ReadLine());
                }

        
            }
        
        Console.WriteLine("That's the magic number! You did it! Dodododoododoooo!");
        Console.WriteLine("Do you want to play again? Type Yes or No");
        answer = Console.ReadLine();
        }
    }
}