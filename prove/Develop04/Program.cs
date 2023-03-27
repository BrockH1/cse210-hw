using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "0";
        string timer;
        int timerNum = 0;
        
        Menu menu = new Menu();
        while (input != "4")
        {
        menu.DisplayMenu();
        input = Console.ReadLine();
        if (input == "1")
        {
            Breather breather = new Breather(timerNum);
            breather.ActivityIntro();
            timer = Console.ReadLine();
            timerNum = int.Parse(timer);
            Breather breather1 = new Breather(timerNum);
            breather1.StartActivity();
            breather1.FinalMessage();

        }

        else if (input == "2")
        {
        Reflector reflector = new Reflector(timerNum);
        reflector.ActivityIntro();
        timer = Console.ReadLine();
        timerNum = int.Parse(timer);
        Reflector reflector1 = new Reflector(timerNum);
        reflector1.StartActivity();
        reflector1.FinalMessage();
        }

        else if(input == "3")
        {
            Lister lister = new Lister(timerNum);
            lister.ActivityIntro();
            timer = Console.ReadLine();
            timerNum = int.Parse(timer);
            Lister lister1 = new Lister(timerNum);
            lister1.StartActivity();
            lister1.FinalMessage();

        }
        }


    }
}