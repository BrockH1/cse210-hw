using System;

class Program
{
    static void Main(string[] args)
    {
        string yes = "yes";
        Word word = new Word();
        Verse verse = new Verse();
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        //word.hideWords();
        scripture.getScripture();
        word.getVerse();

    
        while (yes == "yes")
        {
            scripture.showScripture();
            word.showVerse();
            string input = Console.ReadLine();
            if (input == "")
            {
                word.hideWords();
            }
        }

        
    }
}