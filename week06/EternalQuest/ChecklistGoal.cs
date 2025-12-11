public class ChecklistGoal : Goal
{
    protected int AmountCompleted
    private int _target;
    private int _bonus;

    public int Bonus => _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        AmountCompleted = 0;
        _target = target;
        Bonus = bonus;
    }

    public override void RecordEvent()
    {
        AmountCompleted++;
    }

    public override bool IsComplete() => AmountCompleted >= _target;

    public override string GetDetailsString() =>
        $"{_name}: {_description} (Completed {AmountCompleted}/{_target})";

    public override string GetStringRepresentation() =>
        $"{(IsComplete() ? "[X]" : "[ ]")} {_name} ({_points} pts, {AmountCompleted}/{_target})";

    public override string Serialize() =>
        $"Checklist|{_name}|{_description}|{_points}|{_target}|{Bonus}|{AmountCompleted}";
}