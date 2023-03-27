public class Start:Methods
{

    public void ClockIn()
    {
        AddCode();
        string input;
        DisplayQuery("Please enter your name: ", 30);
        input = Console.ReadLine();
        SetName(input);
        Console.Clear();
        Dots();
        DisplayMessage($"Officer {GetName()}", 30);
        DisplayMessage("You are now clocked in.", 30);
        ScanPerimeter();
        Console.Clear();
        DisplayQuery("Take Inventory? Y o N: ", 30);
        input = Console.ReadLine();
        Console.Clear();
        if (input == "Y")
        {
            CheckInventory();
        }

        DisplayMessage("FIREWALL BREACH", 30);
        DisplayQuery("Counteract breach? Y o N: ", 30);
        input = Console.ReadLine();
        Console.Clear();
        if (input == "Y")
        {
            HackingGame(_code1, 500, 30, 100);
        }

        DisplayMessage("FIREWALL BREACH", 30);
        Console.Clear();
        for (int i = 0; i <1000; i++)
        {
            Random number = new Random();
            int odds = number.Next(0, _code2.Count);
            Console.Write(_code2[odds]);
            Thread.Sleep(1);
        }
        Console.WriteLine();
        Console.Write("Key: ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("[ERROR]");
        Thread.Sleep(2000);
        Console.Clear();
    }
    public virtual void Convo1()
    {
        Console.Clear();
        DisplayMessage("Hello?", 50);
        DisplayMessage("Is somebody receiving this?", 50);
        DisplayOptions("Did you just breach our firewall?", "Who is this?", "This is Station #476 of the United States Space Agency. How did you access this terminal?", "'Don't Respond'");
        GetResponse();
        DisplayResponse("I had no choice. Your coms division wouldn't take me seriously.", "If you give me just a few minutes, I can tell you.", "If you give me just a few minutes, I can explain.", "I know there's somebody there! Please!!!");
        DisplayMessage("I'm a crew member of Station #320. We're about to committ mutiny. Your unit will be space debrit within the next 10 minutes.", 50);
        DisplayOptions("Hope the federal crime was worth the laugh. Disconnect now before I get your identity and report you.", "That's impossible.", "Any proof?", "Why should I believe you?");
        //DisplayResponse("This isn't a joke.", "More impossible than me breaching your firewall?", "");
    }

    public virtual void Sequence()
    {
        ClockIn();
        Convo1();
    }
}