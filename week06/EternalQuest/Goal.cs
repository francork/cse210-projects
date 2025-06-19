public abstract class Goal
{
    protected string _name;
    protected int _points;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();

    public virtual string Serialize() => "";
    public static Goal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        if (parts[0] == "Simple") return new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
        if (parts[0] == "Eternal") return new EternalGoal(parts[1], int.Parse(parts[2]));
        if (parts[0] == "Checklist") return new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
        return null;
    }
}