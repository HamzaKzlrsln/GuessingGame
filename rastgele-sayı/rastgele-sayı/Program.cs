using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int attempts = 5;

            Console.WriteLine("The computer has picked a number between 1 and 100. You have 5 attempts to guess it.");

            while (attempts > 0)
            {
                Console.Write("Enter your guess: ");
                int guess;
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("Congratulations! You have guessed the correct number.");
                        return;
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Go higher.");
                    }
                    else
                    {
                        Console.WriteLine("Go lower.");
                    }

                    attempts--;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }

            Console.WriteLine("Sorry, you have run out of attempts. The number was: " + randomNumber);
        }
    }
}
//ftm
//ftm
//ftm