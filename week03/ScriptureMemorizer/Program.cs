using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.\n");

        // Load scriptures from a text file
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found in file. Please check 'scriptures.txt'.");
            return;
        }

        Random rng = new Random();
        Scripture scripture = scriptures[rng.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden! Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            Console.Write("Press Enter to hide a few words or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            // Hide 1 to 2 random words
            int count = rng.Next(1, 3);
            scripture.HideRandomWords(count);
        }
    }

    static List<Scripture> LoadScripturesFromFile(string fileName)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File '{fileName}' not found. Please add it to the project folder.");
            return scriptures;
        }

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');
            if (parts.Length < 4)
                continue;

            string book = parts[0];
            int chapter = int.Parse(parts[1]);

            if (parts.Length == 4)
            {
                // single verse and verse range
                int verse = int.Parse(parts[2]);
                string text = parts[3];
                scriptures.Add(new Scripture(new Reference(book, chapter, verse), text));
            }
            else if (parts.Length == 5)
            {
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];
                scriptures.Add(new Scripture(new Reference(book, chapter, startVerse, endVerse), text));
            }
        }

        return scriptures;
    }
}

/*
Enhancements added to my program
Loads scriptures from a text file called scriptures.txt
Hides between 1 to 2 words each time for variety
Supports both single verses and verse ranges automatically
Hides only visible words (no duplicates)
Maintains punctuation when hiding words
*/
