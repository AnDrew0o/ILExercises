using System;
using System.Collections.Generic;

namespace WordFrequency
{
    class WordFrequency
    {
        Dictionary<string, int> words = new Dictionary<string, int>();
        public void GetWords(string text)
        {
            foreach (string word in text.ToLower().Split(" "))
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                }
                else
                {
                    words[word]++;
                }
                    
            }
        }
        public string PrintWords()
        {
            string output = "";
            foreach (KeyValuePair<string, int> kvp in words)
            {
                output += ($"{kvp.Key} - {kvp.Value}\n");
            }
            return output;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WordFrequency wordFrequency = new WordFrequency();
            wordFrequency.GetWords("Собака собака кот рыба попугай Змея змея змея кот");
            Console.WriteLine(wordFrequency.PrintWords());
        }

    }
}
