using System.Reflection;
using System.Timers;
using System;
using System.Reflection.Metadata.Ecma335;
public class Activity
{
    protected int _duration;
    protected string _title;
    protected string _desc;
    protected string _finishingmessage;
    public Activity()
    {
        
    }
    public Activity(int durParam, string titleParam, string descParam)
    {
        _duration = durParam * 1000;
        _title = titleParam;
        _desc = descParam;
        _finishingmessage = $"Congratulations on finishing the {_title}!";

        Console.WriteLine(_title);
        Console.WriteLine(_desc);

    }
    public void DisplayAnimation(int duration)
    {
        System.Timers.Timer timer = new System.Timers.Timer(50);
        int passedTime = 0;
        timer.Elapsed += (sender, e) => passedTime +=50;
        timer.Start();
        while(passedTime < duration)
        {
        Console.Write("\b \b \b-");
        Thread.Sleep(50);
        if (passedTime >= duration) break;
        Console.Write("\b \b \b\\");
        Thread.Sleep(50);
        if (passedTime >= duration) break;
        Console.Write("\b \b \b|");
        Thread.Sleep(50);
        if (passedTime >= duration) break;
        Console.Write("\b \b \b/");
        Thread.Sleep(50);
        if (passedTime >= duration) break;
        Console.Write("\b \b \b-");
        Thread.Sleep(50);
        if (passedTime >= duration) break;
        }
        timer.Stop();
        timer.Dispose();
    }
}