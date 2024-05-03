using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            input = int.Parse(response);
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);
        int sum = 0;
        foreach(int item in numbers)
        {
            sum+=item;
        }
        Console.WriteLine($"Total numbers: {numbers.Count}");
        Console.WriteLine($"Sum: {sum}");
        float average = sum / numbers.Count;
        Console.WriteLine($"Average number: {average}");
        int max = 0;
        foreach (int item in numbers)
        {
            if (item > max)
            {
                max = item;
            }
        }
        Console.WriteLine($"Maximum number: {max}");
    }
}