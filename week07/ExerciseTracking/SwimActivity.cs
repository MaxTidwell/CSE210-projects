using System;

public class SwimActivity:Activity
{
    private int _laps;


    public SwimActivity (DateTime date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }



    public override double GetDistance() => _laps * 50 / 1000 * 0.62;
    public override double GetSpeed() => GetDistance() / _time * 60;
    public override double GetPace() => _time / GetDistance();
}