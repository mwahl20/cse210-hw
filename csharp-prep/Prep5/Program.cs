using System;

class Program
{
    static void Main(string[] args)
    {
        static void main()
        {
            DisplayWelcome();
            string username = PromptUserName();
            int favoriteNumber = PromptUserNumber();
            int squarednum = SquareNumber(favoriteNumber);
            DisplayResult(username, squarednum);
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello world!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userID = Console.ReadLine();
            return userID;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }
        static int SquareNumber(int num)
        {
            int squared = num*num; 
            return squared;
        }
        static void DisplayResult(string name, int squarenum)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {squarenum}");
        }
        main();
    }
}