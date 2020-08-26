using System;
using System.Collections.Generic;

namespace Task2App
{
    public class Router
    {
        private Dictionary<int, IAction> menu = new Dictionary<int, IAction>();
        public void GenerateDictionary()
        {
            menu.Add(1, new Navigation());
            menu.Add(2, new MoveAddRecipe());
        }
        public void Selection()
        {
            Console.WriteLine("1. View recipe book \n2. Add new recipe");
            int select = int.Parse(Console.ReadLine());
            if (select > 0 && select <= menu.Count)
            {
                menu[select].ToDo( @"Book\");
            }
            else
            {
                Console.WriteLine("Неправильный ввод");
            }
        }
    }
}