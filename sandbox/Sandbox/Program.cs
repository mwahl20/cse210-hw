using System;
class Program
{
    static void Main(string[] args)
    {
        Course course1 = new Course();
        course1._className = "Prog. w/Classes";
        course1._color = "green";
        course1._courseCode = "CSE 201";
        course1._numberofCredits = 2;
        course1.Display();
    }
}