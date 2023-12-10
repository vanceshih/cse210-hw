using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create activities of each type
        var runningActivity = new Running(DateTime.Now, 30, 3.0);
        var cyclingActivity = new Cycling(DateTime.Now.AddDays(-1), 45, 15.0);
        var swimmingActivity = new Swimming(DateTime.Now.AddDays(-2), 60, 20);

        // Put each activity in the same list
        List<Activity> activities = new List<Activity> { runningActivity, cyclingActivity, swimmingActivity };

        // Iterate through the list and call the GetSummary method on each item
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
