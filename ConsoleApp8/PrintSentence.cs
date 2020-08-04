using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task1
{
    public class PrintSentence : FileChecker,IAction
    {
        public void ToDo(string path)
        {
            if (base.IsFileExists(path))
            {
                string[] sentences = File.ReadAllText(path).Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
                if (sentences.Length >= 3)
                {
                    string senrence = sentences[2];
                    string[] words = senrence.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    string word;
                    List<string> reverseWords = new List<string>();
                    for (int i = 0; i < words.Length; i++)
                    {
                        word = words[i];
                        reverseWords.Add(new string(word.ToCharArray().Reverse().ToArray()));
                    }

                    Console.WriteLine(String.Join(' ', reverseWords));
                }
                else
                {
                    Console.WriteLine("Такого предложения нет!");
                }
            }
        }
    }
}