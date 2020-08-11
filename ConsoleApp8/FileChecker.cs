using System;
using System.IO;
namespace Task1
{
    public class FileChecker
    {
        public bool IsFileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Такого файла не существует!");
                return false;   
            }
        }
    }
}