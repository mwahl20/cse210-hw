public class Cycling : Activity
{
    public double _avgSpeedinkm;
    public Cycling(DateOnly date, double duration, double avgSpeed): base(date, "Cycling", duration)
    {
        _avgSpeedinkm = avgSpeed;
    }
    public override double GetDistance()
    {
        return _avgSpeedinkm*(_duration/60);   
    }
    public override double GetSpeed()
    {
        return _avgSpeedinkm;
    }
    public override double GetPace()
    {
        return 60/_avgSpeedinkm;
    }
}