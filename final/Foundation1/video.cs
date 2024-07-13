using System;
public class Video{
    public string _title;
    public string _author;
    public double _duration;
    public List<Comment> Comments;
    public Video(string title, string author, double duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        Comments = new List<Comment>();
    }
    public void AddComment(Comment newcomment)
    {
        Comments.Add(newcomment);
    }

    public void PrintVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_duration} minutes");
        foreach(var comment in Comments)
    {
        Console.WriteLine($"-{comment._user}: {comment._text}");
    }
    }
}