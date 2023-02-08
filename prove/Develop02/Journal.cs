public class Journal
{
    public List<Entry> Entries = new List<Entry>();
    public List<string> NewEntries = new List<string>();

    public string WhichOne = "Yes"; 


    public void Add(Entry entry)
    {
        if (!Entries.Contains(entry))
        {
            Entries.Add(entry);
        }
    }

    public void Remove(Entry entry)
    {
        if (Entries.Contains(entry))
        {
            Entries.Remove(entry);
        }
    }

    public void DisplayJournal()
    {
            foreach (Entry item in Entries)
            {
                Console.WriteLine(item.Date);
                Console.WriteLine(item.Prompt);
                Console.WriteLine(item.Text);
                Console.WriteLine("");

            }


    }

}