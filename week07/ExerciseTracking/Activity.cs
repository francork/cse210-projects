using System;

public abstract class Activity
{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate() => _date;
    public double GetMinutes() => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary(string activityName)
    {
        return $"{GetDate()} {activityName} ({GetMinutes()} min)- Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}