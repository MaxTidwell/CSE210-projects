using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.") 
    {

    }
    protected override void Run()
    {
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine("\nBreathe in...");
            ShowSpinner(4);
            Console.Clear();
            Console.WriteLine("\nBreathe out...");
            ShowSpinner(6);
            Console.Clear();
        }
    }
}