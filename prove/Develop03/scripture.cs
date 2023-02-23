public class Scripture
{
    Reference reference = new Reference();
    public void getScripture()
    {
        string loadFile = "scripture.txt";
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (string item in lines)
            {
                string[] parts = item.Split("|");
                reference.book = parts[0];
                reference.chapter = parts[1];
                reference.number = parts[2];
            }
    }
    
    Word word = new Word();
    Verse verse = new Verse();
    public void showScripture()
    {

        Console.Write($"{reference.book} ");
        Console.Write($"{reference.chapter}:");
        Console.Write($"{reference.number} ");


    }

        

}
