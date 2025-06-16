public class WritingAssignment : Assignment
{
    private string _title;
    private string _dueDate;

    public WritingAssignment(string studentName, string topic, string title, string dueDate)
        : base(studentName, topic)
    {
        _title = title;
        _dueDate = dueDate;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{studentName} - {_title} (Due: {_dueDate})";
    }
}