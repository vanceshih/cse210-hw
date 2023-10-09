using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }

    // Add a new journal entry with the prompt, response.
    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now.ToString("MM/dd/yyyy") // Get and format the current date
        };
        entries.Add(entry);
    }

    // Display all journal entries.
    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    // Save the current list of entries to a file.
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    // Load journal entries from a file, replacing existing entries.
    public void LoadFromFile(string filename)
    {
        entries.Clear(); // Clear existing entries before loading from the file.
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    entries.Add(new Entry
                    {
                        Date = parts[0],
                        Prompt = parts[1],
                        Response = parts[2]
                    });
                }
            }
        }
    }
}

