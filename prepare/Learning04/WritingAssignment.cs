public class WritingAssignment : Assignment
{
    public string _title;
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string getWritingInformation()
    {
        string newName = getName();
        return _title + " By " + newName;
    }
}