using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    //variables
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    //constructor
    public ListingActivity(): base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }


    //functions
    protected override void Run()
    {
        Random rand = new Random();
        Console.WriteLine("\nPrompt: " + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("You will begin listing items in 3 seconds...");
        ShowSpinner(3);

         List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}