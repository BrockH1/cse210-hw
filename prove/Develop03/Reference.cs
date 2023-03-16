public class Reference
{
    private string _number;
    private string _chapter;
    private string _book;

    public string GetNumber()
    {
        return _number;
    }


    public void SetNumber(string number)
    {
        _number = number;
    }

    public string GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }
}