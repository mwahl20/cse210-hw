using System;

class Program
{
    static void Main(string[] args)
    {
        Job jobOne = new Job();
        jobOne._jobTitle = "Construction";
        jobOne._company = "Self Employed";
        jobOne._startYear = 2015;
        jobOne._endYear = 2016;

        Job jobTwo = new Job();
        jobTwo._jobTitle = "Piano Teacher";
        jobTwo._company = "Self Employed";
        jobTwo._startYear = 2014;
        jobTwo._endYear = 2021;

        Job jobThree = new Job();
        jobThree._jobTitle = "Land Scaping";
        jobThree._company = "Self Employed";
        jobThree._startYear = 2010;
        jobThree._endYear = 2020;

        Job club = new Job();
        club._jobTitle = "Robotics Club mechanic";
        club._company = "FIRST Robotics Competition";
        club._startYear = 2014;
        club._endYear = 2020;

        Job mission = new Job();
        mission._jobTitle = "Community Service coordinator";
        mission._company = "The Church of Jesus Christ of Latter-Day Saints";
        mission._startYear = 2021;
        mission._endYear = 2023;


        Resume mine = new Resume();
        mine._name = "Michael Wahlquist";

        mine._jobs.Add(jobOne);
        mine._jobs.Add(jobTwo);
        mine._jobs.Add(jobThree);
        mine._jobs.Add(club);
        mine._jobs.Add(mission);

        mine.DisplayDeets();
    }
}