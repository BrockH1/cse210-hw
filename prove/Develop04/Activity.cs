public class Activity
{
    private int _timer;

    private string _activity;

    private string _description;

    public string getDescription()
    {
        return _description;
    }

    public string getActivity()
    {
        return _activity;
    }

    public int getTimer()
    {
        return _timer;
    }

    public void setTimer(int timer)
    {
        _timer = timer;
    }

    public Activity(string activity, string description, int timer)
    {
        _activity = activity;

        _description = description;

        _timer = timer;

    }

    public void finalMessage()
    {
        Console.Write("Well Done!! ");

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

        Console.WriteLine($"You have completed another {_timer} seconds of the {_activity} activity.");
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

    public void activityIntro()
    {
        Console.WriteLine($"Welcome to the {_activity} activity!");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session?");
    }



}