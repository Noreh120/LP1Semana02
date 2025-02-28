using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            int tries = 0;

            while (true)
            {
            Console.WriteLine("Give a hole number between 0 and 30.");
            string guessedNumber = Console.ReadLine();

            int guessedValue = Int32.Parse(guessedNumber);

            if (guessedValue < 0 || guessedValue > 30)
            {
                Console.WriteLine("Number must be between 0 and 30. Try again.");
                tries += 1;
                continue;
            }
            else if (guessedValue > numberToGuess)
            {
                Console.WriteLine($"The secret number is lower than {guessedValue}. Try again");
                tries += 1;
                continue;
            }
            else if (guessedValue < numberToGuess)
            {
                Console.WriteLine($"The secret number is higher than {guessedValue}. Try again");
                tries += 1;
                continue;
            }
            else if (guessedValue == numberToGuess)
            {
                tries += 1;
                Console.WriteLine($"You found the secrete number {numberToGuess} after {tries}");
                break;
            }
            }

            
        }
    }
}
