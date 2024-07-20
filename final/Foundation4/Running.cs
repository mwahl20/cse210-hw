public class Running : Activity
{
    public double _distance;
    public Running(DateOnly date, double duration, double distance): base(date,"Running",duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance/(_duration/60);
    }
    public override double GetPace()
    {
        return _duration/_distance;
    }
}