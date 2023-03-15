public class Activity
{
    private int _timer;

    private string _activity;

    private string _description;

    public string GetDescription()
    {
        return _description;
    }

    public string GetActivity()
    {
        return _activity;
    }

    public int GetTimer()
    {
        return _timer;
    }

    public void SetTimer(int timer)
    {
        _timer = timer;
    }

    public Activity(string activity, string description, int timer)
    {
        _activity = activity;

        _description = description;

        _timer = timer;

    }

    public void FinalAnimation()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.Write("^.^");
            Thread.Sleep(200);
            Console.Write("\b\b\b");
            Console.Write("^o^");
            Thread.Sleep(200);
            Console.Write("\b\b\b");
            Console.Write("^O^");
            Thread.Sleep(200);
            Console.Write("\b\b\b");
            Console.Write("^o^");
            Thread.Sleep(200);
            Console.Write("\b\b\b");
        }

    }

    public void FinalMessage()
    {
        Console.Write("Well Done!! ");
        FinalAnimation();
        //Console.WriteLine("");

        Console.Write($"You have completed another {_timer} seconds of the {_activity} activity.");
        FinalAnimation();
        Console.WriteLine("");
    }

    public void ActivityIntro()
    {
        Console.WriteLine($"Welcome to the {_activity} activity!");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session?");
    }

    public void CountDown()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine("\n");
    }



}