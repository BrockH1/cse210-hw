using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "0";
        string timer;
        int timerNum = 0;
        string reflectorDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string breatherDesc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string listerDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Menu menu = new Menu();
        while (input != "4")
        {
        menu.DisplayMenu();
        input = Console.ReadLine();
        if (input == "1")
        {
            Breather breather = new Breather("breathing", breatherDesc, timerNum);
            breather.ActivityIntro();
            timer = Console.ReadLine();
            timerNum = int.Parse(timer);
            Breather breather1 = new Breather("breathing", breatherDesc, timerNum);
            breather1.StartBreathing();

        }

        else if (input == "2")
        {
        Reflector reflector = new Reflector("Reflection", reflectorDesc, timerNum);
        reflector.ActivityIntro();
        timer = Console.ReadLine();
        timerNum = int.Parse(timer);
        Reflector reflector1 = new Reflector("breathing", breatherDesc, timerNum);
        reflector1.StartReflection();
        }

        else if(input == "3")
        {
            Lister lister = new Lister("Listing", listerDesc, timerNum);
            lister.ActivityIntro();
            timer = Console.ReadLine();
            timerNum = int.Parse(timer);
            Lister lister1 = new Lister("Listing", listerDesc, timerNum);
            lister1.StartListing();

        }
        }


    }
}