using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            activityName = "Breathing Activity";
            description = "This activity will help you relax by guiding you to breathe slowly. Clear your mind and focus on your breathing.";
        }

        protected override void RunActivity()
        {
            int duration = GetDuration();
            int elapsed = 0;
            bool breatheIn = true;

            while (elapsed < duration)
            {
                if (breatheIn)
                    Console.WriteLine("Breathe in...");
                else
                    Console.WriteLine("Breathe out...");

                // Pause with countdown of 4 seconds per breath
                for (int i = 4; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                    elapsed++;
                    if (elapsed >= duration)
                        break;
                }
                Console.WriteLine();
                breatheIn = !breatheIn;
            }
        }
    }
}