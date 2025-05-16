using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        // *** NEW FEATURE: Initialize QuoteProvider for "Quote of the Day" ***
        QuoteProvider quoteProvider = new QuoteProvider();

        // *** NEW FEATURE: Show Quote of the Day at program start ***
        Console.WriteLine("Quote of the Day:");
        Console.WriteLine(quoteProvider.GetQuoteOfTheDay());
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // NEW FEATURE: Quote of the day feature :) 
                    Console.WriteLine("\nQuote of the Day:");
                    Console.WriteLine(quoteProvider.GetQuoteOfTheDay());
                    Console.WriteLine();

                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry(prompt, response, date);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added.\n");
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    try
                    {
                        journal.SaveToFile(saveFile);
                        Console.WriteLine("Journal saved successfully.\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving file: {ex.Message}\n");
                    }
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    try
                    {
                        journal.LoadFromFile(loadFile);
                        Console.WriteLine("Journal loaded successfully.\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading file: {ex.Message}\n");
                    }
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }
    }
}