using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
        : base(name, description, points) { }

    public override void RecordEvent() { }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"{_shortName}: {_description}";

    public override string GetStringRepresentation() =>
        $"[∞] {_shortName} ({_points} pts)";
}

