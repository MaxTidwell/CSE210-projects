using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your Username? ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userNumberInput = Console.ReadLine();
            int userNumber = int.Parse(userNumberInput);
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int sqrNumber = number * number;
            return sqrNumber;
        }

        static void DisplayResult(string name, int sqrNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {sqrNumber}");
        }


        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int sqrNumber = SquareNumber(userNumber);
        DisplayResult(userName, sqrNumber);


    }
}