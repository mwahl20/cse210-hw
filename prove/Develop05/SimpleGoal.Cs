public class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, int score) : base(name)
    {
        Score = score;
        isCompleted = false;
    }

    public override void MarkCompleted()
    {
        isCompleted = true;
    }

    public override int CalculateScore()
    {
        return isCompleted ? Score : 0;
    }
    public override bool IsCompleted()
    {
        return isCompleted;
    }
}
