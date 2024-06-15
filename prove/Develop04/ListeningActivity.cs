using System;

class ListeningActivity : Activity
{
    public ListeningActivity(int durParam, string titleParam, string descParam)
    : base(durParam,titleParam,descParam)
    {
        
    }
    public void Start()
    {
        DisplayAnimation(400);
        Console.WriteLine($"During this time please close your eyes and listen to your surroundings for the whole duration");
        Console.WriteLine("3");
        Thread.Sleep(100);
        Console.WriteLine("2");
        Thread.Sleep(100);
        Console.WriteLine("1");
        Thread.Sleep(100);
        Console.WriteLine("Now Listening....");
        DisplayAnimation(_duration);

        Thread.Sleep(100);
        Console.WriteLine(_finishingmessage);
        Console.WriteLine($"You have been meditating for {_duration/1000} seconds.");
    }
}