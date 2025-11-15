using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rng = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Hide a few random visible words
    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0)
            return;

        int toHide = Math.Min(count, visibleWords.Count);

        // Randomly pick which words to hide
        for (int i = 0; i < toHide; i++)
        {
            int index = _rng.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetReferenceText();
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText}\n{scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
