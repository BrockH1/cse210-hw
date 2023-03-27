public class Lister:Activity
{
    public List<string> _questions = new List<string>();

    public string _prompt;

    public Lister (int timer) :base(timer)
    {
        AddQuestions();

    }

    public override void ActivityIntro()
    {
        Console.WriteLine($"Welcome to the listing activity!");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session?");
    }

        public override void FinalMessage()
    {
        Console.Write("Well Done!! ");
        FinalAnimation();

        Console.Write($"You have completed another {GetTimer()} seconds of the listing activity.");
        FinalAnimation();
        Console.WriteLine("");
    }

    public void AddQuestions()
    {
        _questions.Add("Who are people that you appreciate?");
        _questions.Add("What are personal strengths of yours?");
        _questions.Add("Who are people that you have helped this week?");
        _questions.Add("When have you felt the Holy Ghost this month?");
        _questions.Add("Who are some of your personal heroes?");

    }

    public string GetQuestion()
    {
        Random number = new Random();
        int odds = number.Next(0, _questions.Count);
        return _questions[odds];
    }

    public override void StartActivity()
    {
        Console.Write("Get Ready...");
        CountDown();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" ----{GetQuestion()}---- ");
        Console.Write("You may begin in: ");
        CountDown();

        GetResponse();

    }

    public void GetResponse()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTimer());
        DateTime currentTime = DateTime.Now;
        int count = 0;

        while (futureTime > currentTime)
        {
            Console.ReadLine();
            currentTime = DateTime.Now;
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
    }


}