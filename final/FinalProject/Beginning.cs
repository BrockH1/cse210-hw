public class Beginning:Methods
{

    Battle battle = new Battle(5, 5, 5, 5, 5);

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
        Console.Clear();
        DisplayMessage("You have 1 unread message.", 30);
        Console.Clear();
        DisplayMessage($"Officer {GetName()}, an emergency signal was detected 20 lightyears away during your leave. There was no specification other than that it was an emergency.\nFive gun ships were sent to respond to the signal. If all goes well, they should be back by the end of the day. \n-Srgt. Hoops", 30);
        Console.ReadLine();
        ScanPerimeter();
        Console.Clear();
        DisplayQuery("Take Inventory? Y o N: ", 30);
        input = Console.ReadLine();
        Console.Clear();
        if (input == "Y")
        {
            battle.CheckInventory();
            Console.Write("Press anything to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        
        Blink("[Firewall Breach]");
        Console.Clear();
        GiveInstructions();
        DisplayQuery("Preparing to counteract breach", 30);
        HackingGame(_code1, 500, 30, 100);

        Blink("[FIREWALL BREACH]");
        Console.Clear();
        DisplayQuery("Preparing to counteract breach", 30);
        Dots();
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
        Blink("[ERROR]");
        Thread.Sleep(2000);
        Console.Clear();
    }
    public virtual void Convo1()
    {
        Console.Clear();
        Thread.Sleep(2000);
        DisplayMessage("Hello?", 50);
        DisplayMessage("Is somebody receiving this?", 50);
        DisplayOptions("Did you just breach our firewall?", "Who is this?", "This is Station #476 of the United States Space Agency. How did you access this terminal?", "*Don't Respond*");
        GetResponse();
        DisplayResponse("I had no choice. Your coms division wouldn't take me seriously.", "If you give me just a few minutes, I can tell you.", "If you give me just a few minutes, I can explain.", "I know there's somebody there! Please!!!");
        DisplayMessage("I'm a crew member of Station #320. We're about to committ a mutiny. Your unit will be space debrit within the next 10 minutes.", 50);
        DisplayOptions("Hope the federal crime was worth the laugh. Disconnect now before I get your identity and report you.", "That's impossible.", "Any proof?", "Why should I believe you?");
        GetResponse();
        DisplayResponse("This isn't a joke!", "More impossible than me knowing that your station only has 5 gunships on board because of an unspecified emergency singal 20 lightyears away?", "How else could I know that your station only has 5 gunships on board because of an unspecified emergency singal 20 lightyears away?", "Because why would I committ a federal crime just to lie to you?");
        DisplayMessage("Listen, I can help you save the thousands of people on board, but only if you trust me. So you really only have two options. What will it be?", 50);
        Console.Write("\nDo you accept his help? Y or N: ");
    }

    public override void GiveInstructions()
    {
        Console.WriteLine("In this activity, you need to keep track of which numbers in the sequence blink.");
        Console.WriteLine("When the sequence is finished, enter the numbers in the order that they blinked.\n");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();

    }

    public virtual void Sequence()
    {
        ClockIn();
        Convo1();
    }

    public override void StartGame()
    {
    }
}