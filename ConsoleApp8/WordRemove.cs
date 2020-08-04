using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task1
{
    public class WordRemover : IAction
    {
        public void ToDo(string path)
        {
            string newPath = @"" + path.Replace(".", "copy.");
            string readText;
            string pattern;
            
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("Подстрока, которую нужно вырезать:");
                string subString = Console.ReadLine();
                readText = File.ReadAllText(path);
                if (readText.Contains(subString))
                {
                    fileInf.CopyTo(newPath, true);
                    pattern = subString;
                    Regex regex = new Regex(pattern,  RegexOptions.IgnoreCase);
                    string createText = regex.Replace(readText, "");
                    File.WriteAllText(path, createText);
                }
                else
                {
                    Console.WriteLine("Такой подстроки нет!");
                }
            }
            else
            {
                Console.WriteLine("Такого файла не существует!");
            }
        }
    }
}