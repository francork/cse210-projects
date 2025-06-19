public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override int RecordEvent() => _points;
    public override bool IsComplete() => false;
    public override string GetDetailsString() => $"[ ] {_name} (Eternal)";
    public override string Serialize() => $"Eternal|{_name}|{_points}";
}