public abstract class Methods
{
    public bool _decision;

    public List<string> _code1 = new List<string>();

    public List<string> _code2 = new List<string>();

    public List<string> _code3 = new List<string>();

    private string _name;

    private string _input;

    private bool _safe = true;


    public bool IsSafe()
    {
        return _safe;
    }

    public void NotSafe()
    {
        _safe = false;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }


    public string GetInput()
    {
        return _input;
    }

    public void SetInput(string input)
    {  
        _input = input;
    }

    public void AddCode()
    {
        _code1.Add("1");
        _code1.Add("2");

        _code2.Add("D");
        _code2.Add("F");
        _code2.Add("2");
        _code2.Add("f");
        _code2.Add("0");
        _code2.Add("4");
        _code2.Add("w");
        _code2.Add("d");
        _code2.Add("g");
        _code2.Add("5");
        _code2.Add("i");
        _code2.Add("u");
        _code2.Add("7");
        _code2.Add("j");
        _code2.Add("d");
        _code2.Add("4");
        _code2.Add("s");

        _code3.Add("1");
        _code3.Add("2");
        _code3.Add("3");
        _code3.Add("A");
        _code3.Add("B");
        _code3.Add("C");
    }

    public virtual void DisplayOptions (string option1, string option2, string option3, string option4)
    {
        Console.WriteLine();
        Console.WriteLine($"1. {option1}");
        Console.WriteLine($"2. {option2}");
        Console.WriteLine($"3. {option3}");
        Console.WriteLine($"4. {option4}");
    }

    public virtual void DisplayResponse(string response1, string response2, string response3, string response4)
    {
        if (GetInput() == "1")
        {
            DisplayMessage(response1, 50);
        }

        else if (GetInput() == "2")
        {
            DisplayMessage(response2, 50);
        }

        else if (GetInput() == "3")
        {
            DisplayMessage(response3, 50);
        }

        else if (GetInput() == "4")
        {
            DisplayMessage(response4, 50);
        }
    }
    public virtual void GetResponse()
    {
        string response;
        response = Console.ReadLine();
        SetInput(response);
        while (response != "1"&& response != "2" && response!= "3" && response != "4")
        {
            response = Console.ReadLine();
        }
        Console.Clear();
    }

    public virtual void DisplayMessage(string item, int time)
    {
        foreach (char letter in item)
        {
            Console.Write(letter);
            Thread.Sleep(time);
        }
        Console.WriteLine();
        Thread.Sleep(2000);
    }

    public virtual void DisplayQuery(string item, int time)
    {
        foreach (char letter in item)
        {
            Console.Write(letter);
            Thread.Sleep(time);
        }
    }

    public void Dots()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write('.');
            Thread.Sleep(1000);
        }
        Console.Write("\b\b\b");
    }

    public void ScanPerimeter()
    {
        string input;
        Console.Clear();
        DisplayQuery("Scan Perimeter? Y or N: ", 30);
        input = Console.ReadLine();
        Console.Clear();
        if (input == "Y")
        {
        Dots();
        if (IsSafe())
        {
            Console.Clear();
            DisplayMessage("Perimeter is clear.", 30);
        }
        else
        {
            Blink("PERIMETER BREACHED");
        }
        }
    }

    public bool MakeDecision()
    {
        string input;
        input = Console.ReadLine();
        if (input == "Y")
        {
            return _decision = true;
        }

        else
        {
            return _decision = false;
        }
    }

    public void Blink(string word)
    {
        for (int i = 0; i < 4; i++)
        {
        Console.Clear();
        Thread.Sleep(200);
        Console.Write(word);
        Thread.Sleep(200);
        }

        Thread.Sleep(2000);
    }

 

    public void HackingGame(List<string> code, int size, int speed, int difficulty)
    {
        Dots();
        Console.Clear();
        string password = "False";
        string key = "";

        while (password != key)
        {
        key = "";
        for (int i = 0; i < size; i++)
        {
            Random number = new Random();
            Random number2 = new Random();
            int odds = number.Next(0, code.Count);
            int blink = number2.Next(0, difficulty);
            if (blink == 25)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write(" ");
                    Thread.Sleep(150);
                    Console.Write("\b");
                    Console.Write(code[odds]);
                    Thread.Sleep(150);
                    Console.Write("\b");
                }
                Console.Write(code[odds]);
                key += code[odds];
            }
            else
            {
               Console.Write(code[odds]);
            }
            Thread.Sleep(speed);

        }

        Console.WriteLine();
        DisplayQuery("Key: ", 30);
        password = Console.ReadLine();
        Console.Clear();
        if (password == key)
        {
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("[SUCCESS]");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Blink("[ERROR]");
            Thread.Sleep(2000);
            Console.Clear();
            DisplayQuery("Next attempt incoming", 30);
            Dots();
            Console.Clear();
        }
        }
    }

    public abstract void StartGame();

    public abstract void GiveInstructions();
}