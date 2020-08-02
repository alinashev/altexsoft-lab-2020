using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task1
{
    public class ModelRemover
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
    }
}