public class MathAssignment: Assignment //create the child class
{
    private string _textbookSection;
    private string _problems;
    
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) //create a constructor
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }



    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}