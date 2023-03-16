public class Word
{
    private List<string> _newVerse = new List<string>();

    private string _hiddenWord = "";

    private bool _isHidden;

    private int _hiddenCount;
    
    public List<string> GetVerse()
    {
        string loadFile = "scripture.txt";
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (string item in lines)
            {
                string[] part = item.Split("|");
                string[] texts = part[3].Split(" ");
                
                foreach (string thing in texts)
                {
                    _newVerse.Add(thing);
                }
            }
        return _newVerse;
    }
    public void HideWords()
    {
        for (int i = 0; i < _newVerse.Count; i++)
        {
            _hiddenWord = "";
            int count = _newVerse[i].Length;
            Random number = new Random();
            int odds = number.Next(0,5);
            if (odds == 2)
            {
                for (int p = 0; p < count; p++)
                {
                    _hiddenWord += "_";
                }

                _newVerse[i] = _hiddenWord;

            }
        }

    }

    public void ShowVerse()
        {
            foreach (string item in _newVerse)
            {
                Console.Write($"{item} ");
            }
            
        }


    public bool CheckWords()
    {
        foreach (string thing in _newVerse)
        {

            if (thing.Contains("_"))
            {
                _hiddenCount++;
            }

        }
        if (_hiddenCount == _newVerse.Count)
        {
            return _isHidden = true;
        }
        else
        {
            _hiddenCount = 0;
            return _isHidden = false;
        }
    }



}