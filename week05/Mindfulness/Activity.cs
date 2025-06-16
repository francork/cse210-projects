using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string _activityName;
        protected string _description;
        protected int _durationSeconds;

        public Activity(string name, string description)
        {
            _activityName = name;
            _description = description;
        }

        public void Start()
        {
            ShowStartingMessage();
            RunActivity();
            ShowEndingMessage();
        }

        private void ShowStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"--- {_activityName} ---");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();

            Console.Write("Enter duration in seconds: ");
            while (!int.TryParse(Console.ReadLine(), out _durationSeconds) || _durationSeconds <= 0)
            {
                Console.Write("Please enter a valid positive number: ");
            }

            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        private void ShowEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed the {_activityName} for {_durationSeconds} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            string[] spinner = { "|", "/", "-", "\\" };
            int counter = 0;
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(spinner[counter]);
                counter = (counter + 1) % spinner.Length;
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        protected abstract void RunActivity();
    }
}