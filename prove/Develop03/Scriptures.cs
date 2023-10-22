using System;
using System.Collections.Generic;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string referenceText, string text)
    {
        reference = new Reference(referenceText);
        words = ParseWords(text);
    }

    public string GetFullScripture()
    {
        string fullReference = $"{reference.Book} {reference.Verse}";
        return $"{fullReference}: {GetScriptureText()}";
    }

public bool HideNextWords(int numberOfWordsToHide)
{
    List<Word> hiddenWords = words.FindAll(word => word.IsHidden);
    List<Word> visibleWords = words.FindAll(word => !word.IsHidden);

    if (visibleWords.Count == 0)
    {
        return false; // All words are already hidden.
    }

    Random random = new Random();

    for (int i = 0; i < numberOfWordsToHide; i++)
    {
        if (visibleWords.Count == 0)
        {
            break; // Break if there are no more visible words.
        }

        int randomIndex = random.Next(visibleWords.Count);
        visibleWords[randomIndex].IsHidden = true;
        visibleWords.RemoveAt(randomIndex); // Remove the word from the list.
    }

    return true;
}

    public string GetScriptureText()
    {
        string text = reference.ReferenceText + " - ";
        foreach (Word word in words)
        {
            text += word.IsHidden ? "___ " : word.Text + " ";
        }
        return text;
    }

    private List<Word> ParseWords(string text)
    {
        List<Word> wordList = new List<Word>();
        string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordArray)
        {
            wordList.Add(new Word(word, false));
        }
        return wordList;
    }
}