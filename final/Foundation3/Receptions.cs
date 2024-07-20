public class Reception : Event
{
    protected string _rsvp;
    public Reception(string title, string desc, DateTime date, string time, string address, string rsvpemail): base(title, desc, date, time, address)
    {
        _rsvp = rsvpemail;
    }
    public override string FullDetails()
    {
        return $"Event: \n   {StandardDetails()}\n RSVP Email: {_rsvp}";
    }
}