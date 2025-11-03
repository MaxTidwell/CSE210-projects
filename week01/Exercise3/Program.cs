using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = 0;

        do
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (guess == magicNumber)
            { Console.WriteLine("You guessed it!"); }
            else if (guess < magicNumber)
            { Console.WriteLine("Higher"); }
            else if (guess > magicNumber)
            { Console.WriteLine("Lower"); }
        } while (guess != magicNumber);
    }
}