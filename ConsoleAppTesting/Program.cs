// See https://aka.ms/new-console-template for more information
using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            
            Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");

            // Initialize the guess to something outside the range
            int guess = 0;

            // Loop until the user guesses the correct number
            while (guess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Check if the input is a valid integer
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                // Provide feedback on the guess
                if (guess > numberToGuess)
                {
                    Console.WriteLine("Too high, guess again: ");
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine("Too low, guess again: ");
                }
            }

            // Congratulate the user for guessing the correct number
            Console.WriteLine($"Congratulations! You've guessed the right number: {numberToGuess}");
        }
    }
}


