public class Scripture
{
    Reference reference = new Reference();
    public void GetScripture()
    {
        string loadFile = "scripture.txt";
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (string item in lines)
            {
                string[] parts = item.Split("|");
                reference.SetBook(parts[0]);
                reference.SetChapter(parts[1]);
                reference.SetNumber(parts[2]);
            }
    }

    public void ShowScripture()
    {

        Console.Write($"{reference.GetBook()} ");
        Console.Write($"{reference.GetChapter()}:");
        Console.Write($"{reference.GetNumber()} ");


    }

        

}
