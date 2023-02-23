public class Word
{
    public List<string> newVerse = new List<string>();

    Verse verse = new Verse();

    public string hiddenWord = "";

    

    public void getVerse()
    {
        string loadFile = "scripture.txt";
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (string item in lines)
            {
                string[] part = item.Split("|");
                string[] texts = part[3].Split(" ");
                
                foreach (string thing in texts)
                {
                    newVerse.Add(thing);
                }
            }
    }
    public void hideWords()
    {
        for (int i = 0; i < newVerse.Count; i++)
        {
            string hiddenWord = "";
            int count = newVerse[i].Length;
            Random number = new Random();
            int odds = number.Next(0,3);
            if (odds == 2)
            {
                for (int p = 0; p < count; p++)
                {
                    hiddenWord += "_";
                }

                newVerse[i] = hiddenWord;

            }
        }

    }

    public void showVerse()
        {
            foreach (string item in newVerse)
            {
                Console.Write($"{item} ");
            }
            
        }



}