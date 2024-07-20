using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateOnly (2024, 7, 6), 20, 2.5),
            new Cycling(new DateOnly(2024,9,15), 25,14),
            new Swimming(new DateOnly(2024, 7,20), 15, 20)
        };
        foreach(var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}