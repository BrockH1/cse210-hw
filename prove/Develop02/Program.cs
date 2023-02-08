using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
       Journal journal = new Journal();
       FileManager fileManager = new FileManager();
       Menu menu = new Menu();
       List<string> journalEntries = new List<string>();
       List<string> prompts = new List<string>();
       prompts.Add("What was the most exciting thing that happened today?");
       prompts.Add("Who hurt you most?");
       prompts.Add("Who would you take revenge on today?");
       prompts.Add("Who was the weakest link today?");
       prompts.Add("Who gave you 'the look'?");
       prompts.Add("Why did you wake up this morning?");
       string input = "";

       while (input != "5")
       {
        menu.startMenu();
        input = Console.ReadLine();
        if (input == "1")
        {
            entry = getPrompt(prompts);

            journal.Add(entry);


        }

        if (input == "2")
        {
            journal.DisplayJournal();
        }

        if (input == "3")
        {
            fileManager.loadEntry(journal);

        }
    

       if (input == "4")
       {
        fileManager.saveEntry(journal);
        Console.WriteLine("Entries Saved! :)");

       }



    }
    }

    static Entry getPrompt(List<string> prompts)
    {
        Entry entry = new Entry();
        FileManager fileManager = new FileManager();
        Random number = new Random();
        string newPrompt = prompts[number.Next(0,5)];
        Console.WriteLine(newPrompt);
        string entryInput = Console.ReadLine();
        entry.Prompt = newPrompt;
        entry.Text = entryInput;
        entry.Date = DateTime.Now.ToShortDateString();
        return entry;
    }

}