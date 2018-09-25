using System;

namespace hellotest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int rand = rndm.Next(0, 100);
            Console.WriteLine("I've chosen a number between 1 and 100.  Guess what it is.");
            var guess = Console.ReadLine();
            guessNumber(Int32.Parse(guess), rand);

        }
        static void guessNumber(int guess, int answer)
        {
            string newGuess;
            if(guess > answer)
            {
                Console.WriteLine("Your guess is too high.  Try again.");
                newGuess = Console.ReadLine();
                guessNumber(Int32.Parse(newGuess), answer);
            } else if (guess < answer)
            {
                Console.WriteLine("Your guess is too low.  Try again.");
                newGuess = Console.ReadLine();
                guessNumber(Int32.Parse(newGuess), answer);
            } else if (guess == answer)
            {
                Console.WriteLine("Correct!!  Goodbye.");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("What did you do???");
                Console.ReadLine();
            }

        }
    }
}
