using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private readonly List<string> prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "When have you felt the Holy Spirit this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            activityName = "Listing Activity";
            description = "This activity will help you reflect on the good things in your life by listing as many as you can in a certain area.";
        }

        protected override void RunActivity()
        {
            int duration = GetDuration();
            Console.Clear();

            Random rnd = new Random();
            string prompt = prompts[rnd.Next(prompts.Count)];
            Console.WriteLine(prompt);

            Console.WriteLine("You may begin in...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("Start listing your responses. Press Enter after each one.");

            DateTime startTime = DateTime.Now;
            List<string> responses = new List<string>();

            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                if (Console.KeyAvailable)
                {
                    string input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        responses.Add(input.Trim());
                    }
                }
                else
                {
                    Thread.Sleep(100);
                }
            }

            Console.WriteLine($"You listed {responses.Count} items.");
        }
    }
}