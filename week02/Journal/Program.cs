using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine();

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Display word count");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Choose an option!");


            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.Write(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter file name to save: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            else if (choice == "4")
            {
                Console.Write("Enter a file name to load: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
                journal.DisplayAll();
            }

            else if (choice == "5")
                journal.DisplayWordCount(); 

            else if (choice == "6")
            {
                running = false;
            }
        }
    }
}

// Most of the help was from the Microsoft official documentation page: https://learn.microsoft.com/en-us/dotnet/csharp/
// For example saving data to a file, Loading data from a file, using the date object among others