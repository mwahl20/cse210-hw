using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade Percentage? ");
        string userGrade = Console.ReadLine();
        int percentage = int.Parse(userGrade);
        int remainder = percentage % 10;
        string letter = "";
        string additional_grade = "";
        if (remainder >= 7)
        {
            if (percentage > 90 || percentage < 60)
            {
                additional_grade = "";
            }
            else
            {
                additional_grade = "+";
            } 
        }
        else if (remainder <= 3)
        {
            if (percentage < 60)
            {
                additional_grade = "";
            }
            else 
            {
                additional_grade = "-";
            }
        }
        else
        {
            additional_grade = "";
        }

        if (percentage > 90)
        {
            letter = "A";
            
        }
        else if (percentage > 80)
        {
            letter = "B";
            
        }
        else if (percentage > 70)
        {
            letter = "C";
            
        }
        else if (percentage > 60)
        {
            letter = "D";
            
        }
        Console.WriteLine($"Your grade is {letter}{additional_grade}");

        if (percentage > 60)
        {
            Console.WriteLine($"Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine($"Sorry but you failed this year. Maybe next year?");
        }}}