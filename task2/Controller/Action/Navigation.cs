﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Task2App
{
    public class Navigation : IAction
    {
        private Print _print = new Print();
        public void ToDo(string directoryName)
        {
            string choice;
            Dictionary<int, string> dirеctory = new Dictionary<int, string>();
            
            if (Directory.Exists(directoryName))
            {
                while (true)
                {
                    string[] dirs = Directory.GetDirectories(directoryName);
                    string[] fls = Directory.GetFiles(directoryName);
                    Array.Sort(dirs);
                    Array.Sort(fls);
                    dirеctory.Clear();

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

                    int select = Convert.ToInt32(Console.ReadLine());
                    if (select <= dirs.Length + fls.Length)
                    {
                        choice = dirеctory[select];
                        if (!choice.Contains(".json"))
                        {
                            directoryName = choice;
                        }
                        else
                        { 
                            _print.JsonPrint(choice);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice!");
                    }
                }
            }
        }
    }
}