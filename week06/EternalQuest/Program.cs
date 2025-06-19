using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n*** Eternal Quest Menu ***");
            Console.WriteLine("1. Show Goals");
            Console.WriteLine("2. Create a Goal");
            Console.WriteLine("3. Record an Event");
            Console.WriteLine("4. Show Total Points");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Pick an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": ShowGoals(); break;
                case "2": CreateGoal(); break;
                case "3": RecordEvent(); break;
                case "4": Console.WriteLine($"Points: {totalPoints}"); break;
                case "5": SaveGoals(); break;
                case "6": LoadGoals(); break;
                case "7": running = false; break;
                default: Console.WriteLine("Try again."); break;
            }
        }
    }

    static void ShowGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i}. {goals[i].GetDetailsString()}");
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Create a goal: 1=Simple, 2=Eternal, 3=Checklist");
        string type = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
        }
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Pick a goal number to record: ");
        int index = int.Parse(Console.ReadLine());
        int earned = goals[index].RecordEvent();
        totalPoints += earned;
        Console.WriteLine($"You earned {earned} points!");
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalPoints);
            foreach (Goal g in goals)
                writer.WriteLine(g.Serialize());
        }
        Console.WriteLine("Saved!");
    }

    static void LoadGoals()
    {
        goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        totalPoints = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            goals.Add(Goal.Deserialize(lines[i]));
        }
        Console.WriteLine("Loaded!");
    }
}
