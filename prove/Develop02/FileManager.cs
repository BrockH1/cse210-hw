using System.IO;
public class FileManager
{

    public void saveEntry(Journal journal)
    {
        string fileName = "entries.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry item in journal.Entries)
            {
                outputFile.Write($"{item.Date},");
                outputFile.Write($"{item.Prompt},");
                outputFile.Write($"{item.Text}");
                outputFile.WriteLine("");
            }
        }

    }

    public void loadEntry(Journal journal)
    {
        Console.WriteLine("Which file do you want to load?");
        string loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFile);

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split(",");
            entry.Date = parts[0];
            entry.Prompt = parts[1];
            entry.Text = parts[2];
            journal.Add(entry);

        }


    }


}