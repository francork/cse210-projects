using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        { }

        protected override void RunActivity()
        {
            int timeElapsed = 0;

            while (timeElapsed < _durationSeconds)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(4);
                timeElapsed += 4;
                if (timeElapsed >= _durationSeconds) break;

                Console.WriteLine("Breathe out...");
                ShowCountdown(6);
                timeElapsed += 6;
                if (timeElapsed >= _durationSeconds) break;

                Console.WriteLine();
            }
        }
    }
}