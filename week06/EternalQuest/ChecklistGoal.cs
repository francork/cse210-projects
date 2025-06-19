public class ChecklistGoal : Goal
{
    private int _count;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints, int count = 0) : base(name, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _count = count;
    }

    public override int RecordEvent()
    {
        _count++;
        if (_count == _targetCount) return _points + _bonusPoints;
        return _points;
    }

    public override bool IsComplete() => _count >= _targetCount;

    public override string GetDetailsString() => $"[ {(IsComplete() ? "X" : " ")} ] {_name} Completed {_count}/{_targetCount}";

    public override string Serialize() => $"Checklist|{_name}|{_points}|{_targetCount}|{_bonusPoints}|{_count}";
}
