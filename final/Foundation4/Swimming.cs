public class Swimming : Activity
{
    protected int _laps;
    protected double _lapDistance = 50;
    public Swimming(DateOnly date, double duration, int laps, double lapDistance=50) : base(date, "Swimming", duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps*_lapDistance;
    }
    public override double GetSpeed()
    {
        return GetDistance()/(_duration/60);
    }
    public override double GetPace()
    {
        return _duration/GetDistance();
    }
}