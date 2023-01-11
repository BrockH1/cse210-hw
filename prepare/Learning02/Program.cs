using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Banker";
        job1._company = "Wells Fargo";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Movie Star";
        job2._company = "Paramount";
        job2._startYear = 2032;
        job2._endYear = 2041;

        Resume resume = new Resume();
        resume._name = "Brock Hoskins";
        resume._jobList.Add(job1);
        resume._jobList.Add(job2);
        resume.DisplayResume();


    }
}