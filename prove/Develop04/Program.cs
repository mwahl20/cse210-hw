using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
        Console.WriteLine($"Welcome to the Mindfulness app! Please select an activity: \n 1. Breathing Activity \n 2. Listening Activity \n 3. Reflecting Activity \n 4. Listing Activity \n 5. Exit");
        string activityChoice = Console.ReadLine();
        int activity = int.Parse(activityChoice);
        if (activity == 5)
            break;
        Console.WriteLine("How many seconds would you like to participate in this activity?");
        string activityDuration = Console.ReadLine();
        int timer = int.Parse(activityDuration);
        

        switch (activity)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity(timer, "Breathing Activity", "A calming breathing exercise.");
                breathingActivity.Start();
                break;
            case 2:
                ListeningActivity listeningactivity = new ListeningActivity(timer, "Listening Activity", "An activity to increase awareness of surroundings");
                listeningactivity.Start();
                break;
            case 3:
                ReflectingActivity reflectingActivity = new ReflectingActivity(timer, "Reflecting Activity", "An activity to help remember thankfulness and a user's capacity for gratitude.");
                break;
            case 4:
                ListingActivity listingactivity = new ListingActivity(timer, "Listing Activity", "An activity to help mental accuity and capacity to remember objects in a person's life");
                listingactivity.Start();
                break;
        }
        }
    }
}