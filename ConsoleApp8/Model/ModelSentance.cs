using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task1
{
    public class ModelSentance
    {
        public List<string> PrintSentance(string path)
        {
            string readText = File.ReadAllText(path);
            string[] sentences = readText.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
            string senrence = sentences[2];
            string[] words = senrence.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string word;
            List<string> reverseWords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                word = words[i];
                reverseWords.Add(new string(word.ToCharArray().Reverse().ToArray()));
            }

            return reverseWords;
        }
    }
}