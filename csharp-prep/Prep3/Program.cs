using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int solution = randomGenerator.Next(1,100);
        int guess = 0;
        int guesscount = 0;
        string repeat = "Yes";
        do
        {
            guess = 0;
            solution = randomGenerator.Next(1,100);
            guesscount = 0;
            do
            {
                Console.Write("What is your number guess? ");
                string response = Console.ReadLine();
                guess = int.Parse(response);
                if (guess > solution)
                {
                    Console.WriteLine("The guess is too high. Try Lower.");
                }
                else if (guess < solution)
                {
                    Console.WriteLine("The guess is too low. Please try higher.");
                }
                guesscount += 1;
            }while (guess != solution);
            Console.WriteLine($"Congratulations! You guessed the number! It was {solution}. It took you {guesscount} tries. ");

            Console.Write("Would you like to continue? ");
            repeat = Console.ReadLine();
        }while (repeat == "yes");
    }
}