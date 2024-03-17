using System;

namespace Develop02
{
    class Program
    {
        static Journal journal = new Journal();
        static string[] prompts = new[] {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
        static Random random = new Random();

        static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("Welcome to the Journal App!");

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        WriteNewEntry();
                        break;
                    case "2":
                        journal.DisplayJournal();
                        break;
                    case "3":
                        SaveJournal();
                        break;
                    case "4":
                        LoadJournal();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void WriteNewEntry()
        {
            var prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Your response: ");
            var response = Console.ReadLine();
            var entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
            journal.AddEntry(entry);
            Console.WriteLine("Entry added.");
        }

        static void SaveJournal()
        {
            Console.Write("Enter filename to save: ");
            var filename = Console.ReadLine();
            journal.SaveToFile(filename);
            Console.WriteLine("Journal saved.");
        }

        static void LoadJournal()
        {
            Console.Write("Enter filename to load: ");
            var filename = Console.ReadLine();
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded.");
        }
    }
}