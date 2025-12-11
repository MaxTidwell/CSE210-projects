using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent() { }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"{_name}: {_description}";

    public override string GetStringRepresentation() =>
        $"[∞] {_name} ({_points} pts)";

    public override string Serialize() =>
        $"Eternal|{_name}|{_description}|{_points}";
}
