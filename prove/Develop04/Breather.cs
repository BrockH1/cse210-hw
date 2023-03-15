public class Breather : Activity

{

    public Breather(string activity, string description, int timer) :base(activity, description, timer)
    {

    }

    public void BreatheIn()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine("");
    }

    public void BreatheOut()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        //Console.WriteLine("");
    }

    public void StartBreathing()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTimer());
        DateTime currentTime = DateTime.Now;

        Console.Write("Get Ready...");
        CountDown();

        while (futureTime > currentTime)
        {
            Console.Write("Breathe in...");
            CountDown();
            Console.Write("Now breath out...");
            BreatheOut();
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }

        FinalMessage();
    }
}