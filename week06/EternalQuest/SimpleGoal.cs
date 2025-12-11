using System;

public class SimpleGoal : Goal
{
    public bool IsCompleteFlag { get; set; }

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        IsCompleteFlag = false;
    }

    public override void RecordEvent()
    {
        IsCompleteFlag = true;
    }

    public override bool IsComplete() => IsCompleteFlag;

    public override string GetDetailsString() => $"{_name}: {_description}";

    public override string GetStringRepresentation() =>
        $"{(IsCompleteFlag ? "[X]" : "[ ]")} {_name} ({_points} pts)";

    public override string Serialize() =>
        $"Simple|{_name}|{_description}|{_points}|{IsCompleteFlag}";
}
