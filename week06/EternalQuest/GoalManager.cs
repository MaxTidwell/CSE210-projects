using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice;
        do
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": DisplayPlayerInfo(); break;
                case "2": ListGoalNames(); break;
                case "3": ListGoals(); break;
                case "4": CreateGoal(); break;
                case "5": RecordEvent(); break;
                case "6": SaveGoals(); break;
                case "7": LoadGoals(); break;
            }
        } while (choice != "8");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1) Simple 2) Eternal 3) Checklist");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        if (!int.TryParse(Console.ReadLine(), out int pts))
        {
            Console.WriteLine("Invalid points. Goal not created.");
            return;
        }

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, pts));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, pts));
                break;
            case "3":
                Console.Write("Target count: ");
                if (!int.TryParse(Console.ReadLine(), out int target))
                {
                    Console.WriteLine("Invalid target. Goal not created.");
                    return;
                }
                Console.Write("Bonus points: ");
                if (!int.TryParse(Console.ReadLine(), out int bonus))
                {
                    Console.WriteLine("Invalid bonus. Goal not created.");
                    return;
                }
                _goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select goal number to record: ");
        if (!int.TryParse(Console.ReadLine(), out int index))
        {
            Console.WriteLine("Invalid input.");
            return;
        }
        index--;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].Points;

            if (_goals[index] is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score += checklist.Bonus;
            }
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                Goal goal = Goal.Deserialize(lines[i]);
                if (goal != null) _goals.Add(goal);
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
