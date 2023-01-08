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
                total = number + total; 
                count++;
            }
        }
        int average = total / count;
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > numbers[i-1])
            {
                highest = numbers[i];
            }

        }
        Console.WriteLine($"The sum is {total}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The highest number is {highest}.");








    }
}