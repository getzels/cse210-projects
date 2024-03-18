using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine("Press Enter to hide words, type 'quit' to exit.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.ToString());
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            scripture.HideRandomWords(2); // Hides 2 random words
        }
    }
}