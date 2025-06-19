using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new Cycling("03 Nov 2022", 30, 12.0));
        activities.Add(new Swimming("03 Nov 2022", 30, 20));

        foreach (Activity a in activities)
        {
            string name = a is Running ? "Running" :
                          a is Cycling ? "Cycling" : "Swimming";

            Console.WriteLine(a.GetSummary(name));
        }
    }
}