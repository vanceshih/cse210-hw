public class WritingAssignment: Assignment //create the child class
{
    private string _title;
    
    public WritingAssignment(string studentName, string topic, string title) //create a constructor
        : base(studentName, topic)
    {
        _title = title;
    }



    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}