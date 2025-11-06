using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
            Console.WriteLine($"Journal saved to {file}");
        }
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();

            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];

                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded from {file}");
        }

        else
        {
            Console.WriteLine("File not found.");
        }
    }

    // Enhancement: Track users' writing progress by displaying the number of words written 
    // and average number of words per entry
    public void DisplayWordCount()
    {
        int totalWords = 0;

        foreach (Entry entry in _entries)
        {
            totalWords += entry._entryText.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        Console.WriteLine();
        Console.WriteLine($"Total words written: {totalWords}");

        if (_entries.Count > 0)
        {
            double avg = (double)totalWords / _entries.Count;
            Console.WriteLine($"Average words per entry: {avg:F1}");
        }
    }

}
