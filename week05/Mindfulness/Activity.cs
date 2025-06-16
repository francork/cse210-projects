using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        private int duration;
        protected string activityName;
        protected string description;

        public void Start()
        {
            ShowStartingMessage();
            RunActivity();
            ShowEndingMessage();
        }

        private void ShowStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"*** {activityName} ***");
            Console.WriteLine();
            Console.WriteLine(description);
            Console.WriteLine();
            duration = GetDurationFromUser();
            Console.WriteLine("Get ready to begin...");
            PauseWithAnimation(3);
        }

        private int GetDurationFromUser()
        {
            int seconds;
            do
            {
                Console.Write("Enter the duration of the activity in seconds: ");
            } while (!int.TryParse(Console.ReadLine(), out seconds) || seconds <= 0);
            return seconds;
        }

        private void ShowEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done! You have completed the activity.");
            PauseWithAnimation(3);
            Console.WriteLine($"Activity completed: {activityName} ({duration} seconds)");
            PauseWithAnimation(3);
        }

        protected void PauseWithAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected int GetDuration()
        {
            return duration;
        }

        protected abstract void RunActivity();
    }
}