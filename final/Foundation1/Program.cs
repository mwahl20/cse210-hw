using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Can you 3d print the perfect Nutella Spread?", "The Action Lab", 7.34);
        Video v2 = new Video("What does your imagination look like?", "Solar Sands", 20.20);

        v1.AddComment(new Comment("jimmytaco6738", "The obvious next step is to 3d print the bread to make it equally as perfect"));
        v1.AddComment(new Comment("gimmefries", "Sounds like the plot of a movie. Print a weapon, eat the evidence."));

        v2.AddComment(new Comment("Corvus_Erectus", "I don't know why but the most interesting part of this video to me is that Solar Sands is an actual human and not a weird vocaloid"));
        v2.AddComment(new Comment("nacnud2115","everyone is talking about the face reveal but I just saw a hat"));
        v1.PrintVideo();
        Console.WriteLine("\n\n");
        v2.PrintVideo();        
    }
}