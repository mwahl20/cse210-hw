public class EternalGoal : Goal
{
    private int completionCount;

    public EternalGoal(string name, int score) : base(name)
    {
        Score = score;
        completionCount = 0;
    }

    public override void MarkCompleted()
    {
        completionCount++;
    }

    public override int CalculateScore()
    {
        return Score * completionCount;
    }
    public override bool IsCompleted()
    {
        return false;
    }
}
