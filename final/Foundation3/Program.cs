using System;

class Program
{
    static void Main(string[] args)
    {
        Event lecture = new Lectures("Responding to Scam Emails", "Driving scammers insane", new DateTime(2024, 10,31), "7:00 PM", "1450 TED Center St", "An Internet Troll", 1000);
        Event reception = new Reception("Wedding Reception", "Celebrate the Union of Josh and Kenzie Jones!", new DateTime(2024,12,26), "6:00 PM", "Layton Utah Temple", "JonesFamily@gmail.com");
        Event outdoors= new Outdoors("Wahlquist Family Gathering","Come join the Wahlquist Family for an afternoon picnic!", new DateTime(2024, 7,30), "2:00 PM", "140 W 2nd Rexburg");

        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine($"\n{lecture.StandardDetails()}");
        Console.WriteLine($"\n{lecture.MakeDesc()}\n");

        Console.WriteLine("Reception Details");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine($"\n{reception.StandardDetails()}");
        Console.WriteLine($"\n{reception.MakeDesc()}\n");
        
        Console.WriteLine("Outdoor Gathering Details");
        Console.WriteLine(outdoors.FullDetails());
        Console.WriteLine($"\n{outdoors.StandardDetails()}");
        Console.WriteLine($"\n{outdoors.MakeDesc()}\n");
    }
}