public abstract class Activity
{
    private int _timer;

    public int GetTimer()
    {
        return _timer;
    }

    public void SetTimer(int timer)
    {
        _timer = timer;
    }

    public Activity(int timer)
    {
        _timer = timer;
    }

    public virtual void FinalAnimation()
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

    public abstract void StartActivity();

    public abstract void FinalMessage();

    public abstract void ActivityIntro();

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