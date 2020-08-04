using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task1
{
    public class PrintSentance : FileChecker,IAction
    {
        public void ToDo(string path)
        {
            string readText;
            if (base.IsFileExists(path))
            {
                readText = File.ReadAllText(path);
                string[] sentences = readText.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
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