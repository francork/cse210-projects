using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

 
    public string Serialize()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static Entry Deserialize(string line)
    {
        var parts = line.Split('|');
        if(parts.Length == 3)
        {
            return new Entry(parts[1], parts[2], parts[0]);
        }
        else
        {
            throw new Exception("Invalid entry format");
        }
    }
}