using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        string yes = "";
        Word word = new Word();
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        scripture.GetScripture();
        word.GetVerse();
        Console.WriteLine("Welcome to the scripture memorizer! Would you like to play? Type 'Yes' or 'No'");
        yes = Console.ReadLine();

        if (yes == "Yes")
        {
        while (input != "Quit")
        {
            scripture.ShowScripture();
            word.ShowVerse();
            Console.WriteLine();
            Console.Write("Press enter to remove words or type 'Quit' to exit the game.");
            input = Console.ReadLine();
            if (input == "")
            {
                Console.Clear();
                word.HideWords();
            }
            if (word.CheckWords())
            {
                input = "Quit";
            }
        }
        scripture.ShowScripture();
        word.ShowVerse();
        Console.WriteLine();
        Console.Write("Press enter to remove words or type 'Quit' to exit the game.");
        Console.ReadLine();
        Console.Clear();
        }


        
    }

}