using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("1. Goal Type: Simple");
            Console.WriteLine("2. Goal Type: Eternal");
            Console.WriteLine("3. Goal Type: Checklist");
            Console.WriteLine("4. Display Goals");
            Console.WriteLine("5. Record Goal");
            Console.WriteLine("6. Display Total Score");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string sName = Console.ReadLine();
                    Console.Write("Enter goal score: ");
                    int sScore = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new SimpleGoal(sName, sScore));
                    break;
                case "2":
                    Console.Write("Enter goal name: ");
                    string eName = Console.ReadLine();
                    Console.Write("Points per instance: ");
                    int eScore = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new EternalGoal(eName, eScore));
                    break;
                case "3":
                    Console.Write("Enter goal name: ");
                    string cName = Console.ReadLine();
                    Console.Write("Points per step: ");
                    int cScore = int.Parse(Console.ReadLine());
                    Console.Write("How many steps of this goal: ");
                    int steps = int.Parse(Console.ReadLine());
                    Console.Write("How many points for completion: ");
                    int completed = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new ChecklistGoal(cName, cScore, steps, completed));
                    break;
                case "4":
                    goalManager.DisplayGoals();
                    break;
                case "5":
                    goalManager.DisplayGoals();
                    Console.Write("Which goal did you complete?  ");
                    int gindex = int.Parse(Console.ReadLine());
                    goalManager.CompleteGoal(gindex - 1);
                    break;
                case "6":
                    goalManager.DisplayTotalScore();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Nonexistant choice, please try again.");
                    break;
            }
            Thread.Sleep(300);
        }
    }
}
