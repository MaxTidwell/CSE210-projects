using System;

public abstract class Activity
{
    private DateTime _date;
    protected int _time;


    public Activity(DateTime date, int time)
    {
        _date = date;
        _time = time;
    }



    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date: dd MMM yyyy}, ({_time} minutes)- Distance: {GetDistance()} miles, "+
            $"Speed: {GetSpeed()} mph, Pace: {GetPace()} minutes per mile.";
    }
}