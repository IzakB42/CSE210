class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string summary = GetSummary();
        return $"{summary} \n{_title}";
    }
}