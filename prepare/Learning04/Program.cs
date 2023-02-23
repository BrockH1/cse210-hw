using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student = new Assignment("Brock", "Programming");
        MathAssignment math = new MathAssignment("Brock", "Programming", "7.4", "10-11");
        WritingAssignment writing = new WritingAssignment("Brock", "Programming", "Jane Ere");
        
        Console.WriteLine(student.getSummaray());
        Console.WriteLine(math.getHomeworkList());
        Console.WriteLine(writing.getWritingInformation());




    }
}