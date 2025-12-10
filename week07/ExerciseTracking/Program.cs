using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        Activity a1 = new RunActivity(new DateTime(2025, 12, 9), 30, 3.0);
        activities.Add(a1);

        Activity a2 = new BikeActivity(new DateTime(2025, 12, 9), 40, 15.0);
        activities.Add(a2);
        
        Activity a3 = new SwimActivity(new DateTime(2025, 12, 9), 25, 20);
        activities.Add(a3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}