using System;
using System.Collections.Generic;

namespace Task2App
{
    public class Router
    {
        private Dictionary<Int32, IAction> menu = new Dictionary<Int32, IAction>();
        public void GenerateDictionary()
        {
            menu.Add(1, new MoveCategory());
            menu.Add(2, new MoveShowAllIngredients());
        }

        public void Selection()
        {
            Console.WriteLine("1. Категории\n2. Все ингредиенты");
            int select = Int32.Parse(Console.ReadLine());
            if (select > 0 && select <= menu.Count)
            {
                menu[select].ToDo();
            }
            else
            {
                Console.WriteLine("Неправильный ввод");
            }
        }
    }
}