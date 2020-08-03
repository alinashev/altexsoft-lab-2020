using System;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    public class DirectoryProcessing : IAction
    {
        public void ToDo(string directoryName)
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