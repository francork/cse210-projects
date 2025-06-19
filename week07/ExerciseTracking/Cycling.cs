using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (GetSpeed() * GetMinutes()) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => GetMinutes() / GetDistance();
}