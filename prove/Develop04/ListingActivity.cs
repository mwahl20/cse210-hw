using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Timers;
class ListingActivity : Activity
{
    public ListingActivity(int durParam, string titleParam, string descParam)
    : base(durParam,titleParam,descParam)
    {
        
    }
    private List<string> _prompts =  new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private static Random _random = new Random();
    private int itemcount;
    public void Start()
    {
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"You will have {_duration/1000} seconds");
        DisplayAnimation(300);
        Console.WriteLine($"Please list as many items as you can in the duration");
        DisplayAnimation(300);
        Console.WriteLine(prompt);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration/1000);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    itemcount++;
                }
                currentTime = DateTime.Now;
        }
        Console.WriteLine(_finishingmessage);
        Console.WriteLine($"You managed to write {itemcount} items.");
    }
}
