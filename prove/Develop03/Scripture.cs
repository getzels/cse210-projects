using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(Words.Count);
            Words[index].IsHidden = true;
        }
    }

    public override string ToString()
    {
        string scriptureText = string.Join(" ", Words.Select(word => word.IsHidden ? "____" : word.Text));
        return $"{Reference}: {scriptureText}";
    }
}
