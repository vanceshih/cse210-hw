using System;

public class Resume
{

    public string _fullName;
    public List<Job> _jobs= new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_fullName}");
        Console.WriteLine($"Jobs:");
    
        // I need to figure out line 14 and ine 16
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}