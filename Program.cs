using System;
using System.IO;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: WordCounter <path-to-file>");
            return;
        }

        string filePath = args[0];

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string content = File.ReadAllText(filePath);

        int wordCount = CountWords(content);

        Console.WriteLine($"Word count: {wordCount}");
    }

    static int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        // Matches sequences of letters/numbers
        var matches = Regex.Matches(text, @"\b\w+\b");
        return matches.Count;
    }
}
