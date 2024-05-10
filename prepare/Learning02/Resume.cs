using System

public class resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void DisplayDeets()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write("Jobs: ");
        foreach (Job job in _jobs)
        {
            job.DisplayDeets();
        }
    }
}