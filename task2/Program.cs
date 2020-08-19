using System;

namespace Task2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Router router = new Router();
            router.GenerateDictionary();
            router.Selection();
        }
    }
}