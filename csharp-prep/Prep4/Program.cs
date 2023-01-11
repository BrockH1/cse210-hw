using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        List<int> numbers;
        int count = 0;
        numbers = new List<int>();
        int total = 0;
        int number = -1;
        int highest = 0;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
                count ++;
            }
        }
        foreach (int integer in numbers)
        {
           
            total = integer + total;

        }
        foreach (int integer in numbers)
        {
            if (integer > highest)
            {
                highest = integer;
            }
        }
        float average = total / count;
        Console.WriteLine($"The sum is {total}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The highest number is {highest}.");








    }
}