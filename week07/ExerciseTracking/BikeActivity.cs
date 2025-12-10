using System;

public class BikeActivity:Activity
{
    private double _speed;


    public BikeActivity(DateTime date, int time, double speed) : base(date, time)
    {
        _speed = speed;
    }


    public override double GetDistance() => _speed * _time / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}