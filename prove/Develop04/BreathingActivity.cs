using System;

class BreathingActivity : Activity
{
    public BreathingActivity(int durParam, string titleParam, string descParam)
    : base(durParam,titleParam,descParam)
    {
        
    }
    public void Start()
    {
        Console.WriteLine("Starting Breathing Activity");
        Thread.Sleep(200);
        
        Console.WriteLine("Breath in");
        DisplayAnimation(_duration/5);
        Console.WriteLine("Breath Out");
        DisplayAnimation(_duration/5);
        Console.WriteLine("Breath in");
        DisplayAnimation(_duration/5);
        Console.WriteLine("Breath Out");
        DisplayAnimation(_duration/5);
        Console.WriteLine("Breath in");
        DisplayAnimation(_duration/5);

        Console.WriteLine(_finishingmessage);
    }
}