using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private readonly List<string> _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        { }

        protected override void RunActivity()
        {
            Random random = new Random();

            // Show a random prompt
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            Console.WriteLine("You have 5 seconds to think about your list.");
            ShowCountdown(5);

            List<string> items = new List<string>();

            Console.WriteLine("Start listing items. Press enter after each item.");

            DateTime endTime = DateTime.Now.AddSeconds(_durationSeconds);
            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    string input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        items.Add(input.Trim());
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"You listed {items.Count} items.");
        }
    }
}