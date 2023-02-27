using System;

class Program
{
    static void Main(string[] args)
    {
        int timerNum = 0;
        string breatherDesc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Menu menu = new Menu();
        Breather breather = new Breather("breathing", breatherDesc, timerNum);
        menu.displayMenu();
        breather.activityIntro();
        string timer = Console.ReadLine();
        timerNum = int.Parse(timer);
        Breather breather1 = new Breather("breathing", breatherDesc, timerNum);
        breather1.startBreathing();

    }
}