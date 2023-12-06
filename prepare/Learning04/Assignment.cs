public class Assignment //create the parent class
{
    private string _studentName;
    private string _topic;
    
    public Assignment(string studentName, string topic) //create a constructor that receives a student name and topic 
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName() // getter for private variable
    {
        return _studentName;
    }
    public string GetTopic() // getter for private variable
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}