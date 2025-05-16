using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if(entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
        foreach(var entry in entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine("--------------------------");
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach(var entry in entries)
        {
            writer.WriteLine(entry.Serialize());
        }
    }

    public void LoadFromFile(string filename)
    {
        if(!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach(var line in lines)
        {
            try
            {
                var entry = Entry.Deserialize(line);
                entries.Add(entry);
            }
            catch
            {
                Console.WriteLine("Warning: Skipped invalid entry in file.");
            }
        }
    }
}