using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task1
{
    public class Model
    {
        public int WordRemover(string path, string subString)
        {
            string newPath = @"" + path.Replace(".", "copy.");

            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath, true);
            }

            string readText = File.ReadAllText(path);
            string pattern = subString;
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            string createText = regex.Replace(readText, "");
            File.WriteAllText(path, createText);
            int result = String.Compare(readText, createText);


            return result;
        }

        public List<string> AmountAndWords(string path)
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

        public void DirectoryProcessing(string directoryName)
        {
            Dictionary<Int32, string> dirеctory = new Dictionary<int, string>();
            while (true)
            {
                string[] dirs = Directory.GetDirectories(directoryName);
                string[] fls = Directory.GetFiles(directoryName);
                dirеctory.Clear();

                if (Directory.Exists(directoryName))
                {
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        dirеctory.Add(i + 1, dirs[i]);
                    }

                    for (int i = 0; i < fls.Length; i++)
                    {
                        dirеctory.Add(i + dirs.Length + 1, fls[i]);
                    }

                    foreach (var d in dirеctory)
                    {
                        Console.WriteLine("{0} - {1}", d.Key, d.Value);
                    }
                }

                int select = Convert.ToInt32(Console.ReadLine());
                directoryName = dirеctory[select];
            }
        }
    }
}