public class Lectures: Event
{
    protected string _speaker;
    protected int _capacity;

    public Lectures(string title, string desc, DateTime date, string time, string address, string speaker, int capacity): base(title,desc,date,time,address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string FullDetails()
    {
        return $"Event: \n   {StandardDetails()}\n   By {_speaker}\n   Max Capacity: {_capacity}";
    }
}