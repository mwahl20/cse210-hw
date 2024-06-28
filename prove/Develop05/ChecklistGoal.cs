public class ChecklistGoal : Goal
{
    private int steps;
    private int completedSteps;
    private int bonus;

    public ChecklistGoal(string goal, int score, int steps, int bonus) : base(goal)
    {
        Score = score;
        this.steps = steps;
        completedSteps = 0;
        this.bonus = bonus;
    }

    public override void MarkCompleted()
    {
        if (completedSteps < steps)
        {
            completedSteps++;
        }
    }

    public override int CalculateScore()
    {
        return (Score * completedSteps) + (completedSteps == steps ? bonus : 0);
    }
    public override bool IsCompleted()
    {
        return completedSteps == steps;
    }
}
