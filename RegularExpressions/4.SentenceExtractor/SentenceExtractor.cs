﻿namespace _4.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main(string[] args)
        {

            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = string.Format(@"(?<=\s|^)[^!.?]*\b{0}\b[^!.?]*[!.?]", word);
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
            Console.WriteLine("Found {0} matches", matches.Count);
            foreach (Match sentence in matches)
            {
                Console.WriteLine(sentence.Groups[0]);
            }
        }
    }
}
