using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Choose an activity: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity ");
            Console.WriteLine("4. Quit");
            Console.Write("Enter choice: ");

            string _choice = Console.ReadLine();

            Activity activity;
            if (_choice == "1")
            {
                activity = new BreathingActivity();
            }
            else if (_choice == "2")
            {
                activity = new ListingActivity();
            }
            else if (_choice == "3")
            {
                activity = new ReflectingActivity();
            }
            else if (_choice == "4")
            {
                Console.WriteLine("Goodbye.");
                running = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
                return;
            }

            activity.Start();

            if (running)
            {
            Console.Clear();
            }
        }
    }
}
