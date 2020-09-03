﻿﻿using System;
using System.IO;

namespace Task2App
{
    public class Print
    {
        public void JsonPrint (string path)
        {
            string _jsonString = File.ReadAllText(path);
            Console.WriteLine(_jsonString);
        }
    }
}