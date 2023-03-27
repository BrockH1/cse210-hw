public class Reflector : Activity
{
    public string input;
    public int odds = 0;

    public List <string> _promptList = new List<string>();
    public List <string> _prompts = new List<string>();

    public List <string> _stoodUp = new List<string>();

    public List <string> _difficult = new List<string>();

    public List <string> _help = new List<string>();

    public List <string> _selfless = new List<string>();
    public Reflector(int timer) :base(timer)
    {
        AddPrompts();

    }

    public override void ActivityIntro()
    {
        Console.WriteLine($"Welcome to the reflection activity!");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session?");
    }

        public override void FinalMessage()
    {
        Console.Write("Well Done!! ");
        FinalAnimation();

        Console.Write($"You have completed another {GetTimer()} seconds of the refletion activity.");
        FinalAnimation();
        Console.WriteLine("");
    }

    public override void FinalAnimation()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.Write("  ()  ");
            Thread.Sleep(300);
            Console.Write("\b\b\b\b\b\b");
            Console.Write(" (  ) ");
            Thread.Sleep(300);
            Console.Write("\b\b\b\b\b\b");
            Console.Write("(    )");
            Thread.Sleep(300);
            Console.Write("\b\b\b\b\b\b");
            Console.Write(" (  ) ");
            Thread.Sleep(300);
            Console.Write("\b\b\b\b\b\b");

        }

    }

    public void AddPrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _stoodUp.Add("Why was this experience meaningful to you?");
        _stoodUp.Add("Have you ever done anything like this before?");

        _difficult.Add("How did you get started?");
        _difficult.Add("How did you feel when it was complete?");
        _difficult.Add("What made this time different than other times when you were not as successful?");

        _help.Add("What is your favorite thing about this experience?");
        _help.Add("hat could you learn from this experience that applies to other situations?");

        _selfless.Add("What did you learn about yourself through this experience?");
        _selfless.Add("How can you keep this experience in mind in the future?");
    }

   public List<string> getPrompt(int odds)
   {
       List<string> results = new List<string>();

       if (odds == 0)
       {
           results = _stoodUp;
       }
       else if (odds == 1)
       {
           results = _difficult;
       }
       else if (odds == 2)
       {
           results = _help;
       }
       else
       {
           results = _selfless;
       }
       return results;

    }

    public override void StartActivity()
    {
        Random number = new Random();
        int odds = number.Next(0,_prompts.Count);
        List<string> promptList = getPrompt(odds);

        odds = number.Next(0,_prompts.Count);

        Console.Write("Get Ready...");
        CountDown();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" ----{_prompts[odds]}---- ");
        Console.WriteLine("When you have something in mind, press enter.");
        while (input != "")
        {
            input = Console.ReadLine();
        }

        Console.WriteLine("Now ponder each of the questions as they related to this experience");
        Console.Write("You may begin in: ");
        CountDown();

        foreach (string item in promptList)
        {
            Console.Write($"{item}" );
            FinalAnimation();
            Console.WriteLine("");
        }


    }



    

}