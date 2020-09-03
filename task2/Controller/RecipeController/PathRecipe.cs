﻿﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Task2App
{
    public class PathRecipe
    {
        private NewRecipe _newrecipe = new NewRecipe();
        private string path;
        string choice;
        public string name;
        private Dictionary<int, string> dirеctory = new Dictionary<int, string>();

        public string GeneratePath(string directoryName)
        {
            while (true)
            {
                string[] dirs = Directory.GetDirectories(directoryName);
                Array.Sort(dirs);
                dirеctory.Clear();
                for (int i = 0; i < dirs.Length; i++)
                {
                    dirеctory.Add(i + 1, dirs[i]);
                }

                foreach (var d in dirеctory)
                {
                    Console.WriteLine("{0} - {1}", d.Key, d.Value);
                }

                int select = Convert.ToInt32(Console.ReadLine());
                if (select <= dirs.Length)
                {
                    choice = dirеctory[select];
                    if (!choice.Contains("Recipe"))
                    {
                        directoryName = choice;
                    }
                    else
                    {
                        name = _newrecipe.AddName();
                        path = directoryName + @"\Recipe\" + name;
                        Directory.CreateDirectory(path);
                        Console.WriteLine(path);
                        return path;
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