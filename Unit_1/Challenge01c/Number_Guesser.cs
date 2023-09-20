using System;

namespace NumberGuesser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 10;
            int guess;
            int number;
            String response;

            while (playAgain)
            {
                guess = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!");
                

                Console.WriteLine("Would you like to play again? Yes or No: ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Yes")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}