public class Breather : Activity

{

    public Breather(string activity, string description, int timer) :base(activity, description, timer)
    {

    }

    public void breatheIn()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine("");
    }

    public void breatheOut()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine("");
    }

    public void startBreathing()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getTimer());
        DateTime currentTime = DateTime.Now;
        Console.Write("Get ready...");
        breatheIn();
        Console.WriteLine("\n");
        while (futureTime > currentTime)
        {
            Console.Write("Breathe in...");
            breatheIn();
            Console.Write("Now breath out...");
            breatheOut();
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }

        finalMessage();
    }
}