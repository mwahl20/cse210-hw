using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals;
    private int totalScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int item = 0; item < goals.Count; item++)
        {
            Console.WriteLine($"{item + 1}. {goals[item].Name} - Score: {goals[item].CalculateScore()}");
        }
    }

    public void CompleteGoal(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            goal.MarkCompleted();
            totalScore += goal.CalculateScore();
            if (goal.IsCompleted() && !(goal is EternalGoal))
            {
                goals.RemoveAt(index);
            }
        }
    }

    public void DisplayTotalScore()
    {
        Console.WriteLine($"Your total score is: {totalScore} points");
    }
}
