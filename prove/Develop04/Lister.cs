public class Lister:Activity
{
    public List<string> _questions = new List<string>();

    public string _prompt;

    public Lister (string activity, string description, int timer) :base(activity, description, timer)
    {
        AddQuestions();

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

    public void StartListing()
    {
        Console.Write("Get Ready...");
        CountDown();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" ----{GetQuestion()}---- ");
        Console.Write("You may begin in: ");
        CountDown();

        GetResponse();

        FinalMessage();

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