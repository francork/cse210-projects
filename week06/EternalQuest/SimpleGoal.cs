public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points, bool isComplete = false) : base(name, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => $"[ {(IsComplete() ? "X" : " ")} ] {_name}";

    public override string Serialize() => $"Simple|{_name}|{_points}|{_isComplete}";
}