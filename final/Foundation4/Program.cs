using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create activities
        Running runningActivity = new Running(DateTime.Now, 30, 3.0);
        Cycling cyclingActivity = new Cycling(DateTime.Now.AddDays(1), 45, 20.0);
        Swimming swimmingActivity = new Swimming(DateTime.Now.AddDays(2), 40, 15);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Display summaries for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
