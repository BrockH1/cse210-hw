public class newEntry
{
    public string _date = "";
    
    public List<newEntry> _prompts = new List<newEntry>();

    public string _userInput = "";

    public void journalEntry(string _date, string _prompt, string _userInput)
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompts);
        _userInput = Console.ReadLine();


    }

}