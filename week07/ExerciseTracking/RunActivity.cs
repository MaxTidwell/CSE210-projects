using System;

public class RunActivity:Activity
{
    private double _distance;
    public RunActivity(DateTime date, int time, double distance) : base(date, time)
    {
        _distance = distance;
    }


    public override double GetDistance() => _distance;

    public override double GetSpeed() => _distance / _time * 60;

    public override double GetPace() => _time / _distance;

}