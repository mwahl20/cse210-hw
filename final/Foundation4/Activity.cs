public abstract class Activity
{
    protected DateOnly _date;
    protected string _exerType;
    protected double _duration;
    public Activity(DateOnly date, string exerType, double duration)
    {
        _date = date;
        _exerType=exerType;
        _duration=duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date}, {_exerType}, {_duration} minutes, {GetDistance():0.00} km, {GetSpeed():0.00} km/hr, {GetPace()} min/km";
    }
}