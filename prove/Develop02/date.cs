public class Date
{
    public string _dateText = "";
    public void getDate()
    {
        DateTime _date = DateTime.Now;
        _dateText = _date.ToShortDateString();
    }
}
