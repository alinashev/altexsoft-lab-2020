using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task1
{
    public class WordRemove : FileChecker,IAction
    {
        public void ToDo(string path)
        {
            string newPath = @"" + path.Replace(".", "copy.");

            if (base.IsFileExists(path))
            {
                FileInfo fileInf = new FileInfo(path);
                Console.WriteLine("Подстрока, которую нужно вырезать:");
                string subString = Console.ReadLine();
                string readText = File.ReadAllText(path);
                if (readText.Contains(subString))
                {
                    fileInf.CopyTo(newPath, true);
                    string pattern = subString;
                    Regex regex = new Regex(pattern,  RegexOptions.IgnoreCase);
                    string createText = regex.Replace(readText, "");
                    File.WriteAllText(path, createText);
                }
                else
                {
                    Console.WriteLine("Такой подстроки нет!");
                }
            }
        }
    }
}