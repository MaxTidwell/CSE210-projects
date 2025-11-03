using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentString = Console.ReadLine();

        string letter = "F";
        int percent = int.Parse(percentString);

        if (percent >= 90)
        { letter = "A"; }
        else if (percent >= 80)
        { letter = "B"; }
        else if (percent >= 70)
        { letter = "C"; }
        else if (percent >= 60)
        { letter = "D"; }
        else
        { letter = "F"; }

        Console.Write($"your grade is {letter}. ");

        if (percent >= 70)
        {
            Console.WriteLine("You have passed the course.");
        }
        else
        {
            Console.WriteLine("You have not passed, please try again.");
        }


    }
}