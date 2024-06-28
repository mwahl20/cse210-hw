using System;

public abstract class Goal
{
    public string Name { get; set; }
    public int Score { get; protected set; }

    public Goal(string name)
    {
        Name = name;
    }

    public abstract void MarkCompleted();
    public abstract int CalculateScore();
    public abstract bool IsCompleted();
}
