using System;

namespace MindfulnessApp
{
    class Program
    {
        private static int _breathingCount = 0;
        private static int _reflectionCount = 0;
        private static int _listingCount = 0;

        static void Main(string[] args)
        {
            bool exitRequested = false;

            while (!exitRequested)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Activities Menu:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var breathingActivity = new BreathingActivity();
                        breathingActivity.Start();
                        _breathingCount++;
                        break;

                    case "2":
                        var reflectionActivity = new ReflectionActivity();
                        reflectionActivity.Start();
                        _reflectionCount++;
                        break;

                    case "3":
                        var listingActivity = new ListingActivity();
                        listingActivity.Start();
                        _listingCount++;
                        break;

                    case "4":
                        exitRequested = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Session Summary:");
            Console.WriteLine($"Breathing Activities completed: {_breathingCount}");
            Console.WriteLine($"Reflection Activities completed: {_reflectionCount}");
            Console.WriteLine($"Listing Activities completed: {_listingCount}");
            Console.WriteLine("\nThank you for using the mindfulness program!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}