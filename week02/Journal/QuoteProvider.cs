using System;
using System.Collections.Generic;

public class QuoteProvider
{
    private List<string> quotes = new List<string>()
    {
        "The best way to get started is to quit talking and begin doing. – Walt Disney",
        "Don't let yesterday take up too much of today. – Will Rogers",
        "It's not whether you get knocked down, it's whether you get up. – Vince Lombardi",
        "If you are working on something exciting, it will keep you motivated. – Unknown",
        "Success is not in what you have, but who you are. – Bo Bennett"
    };

    private Random random = new Random();

    public string GetQuoteOfTheDay()
    {
        int index = random.Next(quotes.Count);
        return quotes[index];
    }
}