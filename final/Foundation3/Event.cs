public class Event
{
    private string _desc;
    private string _title;
    private DateTime _date;
    private string _time;
    private string _address;
    public Event(string title, string desc, DateTime date, string time, string address)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return $"{_title} \n   {_desc}\n   {_date.ToShortDateString()}  @ {_time}\n   @{_address}";
    }
    public virtual string FullDetails()
    {
        return StandardDetails();
    }
    public string MakeDesc()
    {
        return $"Event Type: {GetType().Name}\nTitle: {_title}\nTime: {_time}\nAddress: {_address}";
    }
}