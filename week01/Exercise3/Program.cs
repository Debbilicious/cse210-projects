using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
    
        do // stretch challenge: repeat the whole game if user wants to play again
        {
            
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 101);
                int guess = -1;
                int guessCount = 0;

                Console.WriteLine("Welcome to the Number Guessing Game!");

                do
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    guessCount++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                    }
                } while (guess != magicNumber);
            
                // Stretch challenge: ask user if they want to play again
                Console.Write("Do you want to play again? (yes/no): ");
                playAgain = Console.ReadLine().ToLower();
        } while (playAgain == "yes");
        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}