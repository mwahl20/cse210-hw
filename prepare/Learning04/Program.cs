using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Michael Wahlquist", "Differential Equations");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Michael Wahlquist", "Thermodynamics", "6.4", "22-34");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Benjamin Franklin", "Church History", "The causes of the Cold War");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}