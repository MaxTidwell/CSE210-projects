using System;

public abstract class Activity
{
    //variables
    protected string _name;
    protected string _description;
    protected int _duration;

    //constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    public void Start()
    {
        DisplayStartingMessage();
        Run();
        DisplayEndingMessage();
    }


    protected abstract void Run();



    //functions
    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine() ?? "30");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations, you have completed the {_name} for {_duration} seconds.");
        ShowSpinner(5);
    }
    protected void ShowSpinner(int seconds)
    {
         string[] sequence = { "|", "/", "—", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(sequence[i]);
            Thread.Sleep(200);
            Console.Write("\b");
            i = (i + 1) % sequence.Length;
        }
    }
}