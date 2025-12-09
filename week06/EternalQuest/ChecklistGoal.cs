using System; 

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;



    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, string points, int target, int bonus)
            : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
        }

        public override bool IsComplete() => _amountCompleted >= _target;

        public override string GetDetailsString() =>
            $"{_shortName}: {_description} (Completed {_amountCompleted}/{_target})";

        public override string GetStringRepresentation() =>
            $"{(IsComplete() ? "[X]" : "[ ]")} {_shortName} ({_points} pts, {_amountCompleted}/{_target})";
    }
}
