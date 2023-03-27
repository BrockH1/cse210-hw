public class Breather : Activity

{

    public Breather(int timer) :base(timer)
    {

    }

    public override void ActivityIntro()
    {
        Console.WriteLine("Welcome to the breathing activity!");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session?");
    }

        public override void FinalMessage()
    {
        Console.Write("Well Done!! ");
        FinalAnimation();

        Console.Write($"You have completed another {GetTimer()} seconds of the breathing activity.");
        FinalAnimation();
        Console.WriteLine("");
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

    public override void StartActivity()
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
    }
}