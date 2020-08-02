using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Task1
{
    public class ModelAmount
    {public List<string> AmountAndWords(string path)
        {
            string readText = File.ReadAllText(path);
            Regex regex = new Regex(@"[^a-zA-Z0-9'\s]+", RegexOptions.Compiled);
            readText = regex.Replace(readText, "");
            Regex regexPattern = new Regex(@"[^a-zA-Z0-9'\S+]+", RegexOptions.Compiled);
            string[] words = regexPattern.Split(readText);

            Console.WriteLine("Количество слов:" + words.Length);

            List<string> resultWords = new List<string>();
            string word;
            for (int i = 9; i < words.Length; i += 10)
            {
                word = words[i];
                resultWords.Add(word);
            }

            return resultWords;
        }
    }
}