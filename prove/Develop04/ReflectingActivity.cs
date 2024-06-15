using System;
using System.Runtime.CompilerServices;

class ReflectingActivity : Activity
{
    public ReflectingActivity(int durParam, string titleParam, string descParam)
    : base(durParam,titleParam,descParam)
    {

    }
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private string input;
    public void Start()
    {
        
        DisplayAnimation(400);
        Console.WriteLine("Get ready to recieve your prompt");
        Console.WriteLine(prompts[new Random().Next(prompts.Count)]);
        DisplayAnimation(300);
        Console.WriteLine(questions[new Random().Next(questions.Count)]);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration/1000);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            input = Console.ReadLine();
            currentTime = DateTime.Now;
        }
        string[] words = input.Split();
        DisplayAnimation(200);
        Console.WriteLine(_finishingmessage);
        Console.WriteLine($"You managed to write {words.Length} items.");
    }
}