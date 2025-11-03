using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string input = Console.ReadLine();

        int number = int.Parse(input);

        while (number != 0)
        {
            numbers.Add(number);

            Console.Write("Enter number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
        }

        int sum = 0;
        foreach (int i in numbers)
        { sum = sum + i; }
        Console.WriteLine($"The Sum is: {sum}");


        float average = ((float)sum) / numbers.Count();
        Console.WriteLine($"The average is: {average}");


        int highest = 0;
        foreach (int i in numbers)
        {
            if (i > highest)
            { highest = i; }
        }
        Console.WriteLine($"The largest number is: {highest}");
    }
}