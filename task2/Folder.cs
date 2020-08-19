using System;
using System.IO;

namespace Task2App
{
    public class Folder
    {
        protected string GetPathFolder()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"jsons\");
        }
    }
}