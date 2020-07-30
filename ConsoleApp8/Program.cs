using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void WordRemover(string path)
        {
            Console.WriteLine("Подстрока, которую нужно вырезать:");
            string subString = Console.ReadLine();
            string newPath = @"" + path.Replace(".", "copy.");

            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath, true);
            }
            
            string readText = File.ReadAllText(path);
            string pattern = subString;
            Regex regex = new Regex(pattern,  RegexOptions.IgnoreCase);
            string createText = regex.Replace(readText, "");
            File.WriteAllText(path, createText);
            int result = String.Compare(readText, createText);
            if (result == 0)
            {
                Console.WriteLine("Такой подстроки нет!");
            }
            
        }

        static void  AmountAndWords(string path)
        {
            string readText = File.ReadAllText(path);
            Regex regex = new Regex(@"[^a-zA-Z0-9'\s]+", RegexOptions.Compiled);
            readText = regex.Replace(readText, "");
            Regex regexPattern = new Regex(@"[^a-zA-Z0-9'\S+]+", RegexOptions.Compiled);
            string[] words = regexPattern.Split(readText);
            
            Console.WriteLine("Количество слов:" + words.Length);
            
            List<string> resultWords = new List<string>();
            string word;
            for (int i = 9; i < words.Length; i += 10 )
            {
                word = words[i];
                resultWords.Add(word);
            }
            Console.WriteLine(String.Join(',', resultWords));
        }

        static void PrintSentance(string path)
        {
            string readText = File.ReadAllText(path);
            string [] sentences = readText.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
            string senrence = sentences[2]; 
            string[] words = senrence.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string word; 
            List<string> reverseWords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                word = words[i];
                reverseWords.Add(new string(word.ToCharArray().Reverse().ToArray()));
            }
            Console.WriteLine(String.Join(separator: ' ', reverseWords));
        }
           
        static void DirectoryProcessing(string directoryName)
        {
            while(true)
            {
                string[] dirs = Directory.GetDirectories(directoryName);
                string[] fls = Directory.GetFiles(directoryName); 
                Dictionary<int, string> dirеctory = new Dictionary<int, string>();

                if (Directory.Exists(directoryName))
                {
                    for(int i = 0; i < dirs.Length; i++) {dirеctory.Add(i+1, dirs[i]); }
                    for(int i = 0; i < fls.Length; i++) {dirеctory.Add(i+dirs.Length + 1, fls[i]); }
                
                    foreach (var d in dirеctory)
                    {
                        Console.WriteLine("{0} - {1}", d.Key, d.Value);
                    }
                }
                int select = Convert.ToInt32(Console.ReadLine( ));
                directoryName = dirеctory[select];
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Вызвать метод 1\n2 - Вызвать метод 2\n3 - Вызвать метод 3\n4 - Вызвать метод 4");
            string select = Console.ReadLine();
            
            Console.WriteLine("Введите путь: ");
            string pathToFile = @"" + Console.ReadLine();
            
            switch(select)
            {
                case "1":
                    WordRemover(pathToFile);
                    break;
                case "2":
                    AmountAndWords(pathToFile);
                    break;
                case "3":
                    PrintSentance(pathToFile);
                    break;
                case "4":
                    DirectoryProcessing(pathToFile);
                    break;
                default:
                    Console.WriteLine("Некорректный ввод!");
                    break;
            }
        }
    }
}