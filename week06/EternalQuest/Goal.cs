using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public int Points => _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    public abstract string Serialize();

    public static Goal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        string type = parts[0];
        switch (type)
        {
            case "Simple":
                return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { IsCompleteFlag = bool.Parse(parts[4]) };
            case "Eternal":
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            case "Checklist":
                return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]))
                { AmountCompleted = int.Parse(parts[6]) };
            default:
                return null;
        }
    }
}
