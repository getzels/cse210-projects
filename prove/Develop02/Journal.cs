using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}\n");
        }
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, entries.Select(entry => entry.ToString()));
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            entries.Add(new Entry(parts[0], parts[1], parts[2]));
        }
    }
}
