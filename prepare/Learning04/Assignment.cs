public class Assignment
{
    private string _studentName;

    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;

    }

    public string getName()
    {
        return _studentName;
    }

    public string getTopic()
    {
        return _topic;
    }

    public string getSummaray()
    {
        return "Name: " + _studentName + "| Topic: " +  _topic;
    }
}