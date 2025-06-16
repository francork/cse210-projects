using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Mindfulness App");
                Console.WriteLine("Choose an activity to begin:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Exit");
                Console.Write("Option: ");

                string option = Console.ReadLine();

                Activity activity = null;

                switch (option)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        exit = true;
                        continue;
                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again...");
                        Console.ReadLine();
                        continue;
                }

                activity.Start();
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}