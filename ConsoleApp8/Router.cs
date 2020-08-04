using System;
using System.Collections.Generic;

namespace Task1
{
    public class Router
    {
        private Input input;
        private Dictionary<Int32, IAction> menu = new Dictionary<int, IAction>();

        public Router(Input input)
        {
            this.input = input;
        }
        public void GenerateMenu()
        {
            menu.Add(1, new WordRemover());
            menu.Add(2, new AmountAndWords());
            menu.Add(3, new PrintSentance());
            menu.Add(4, new DirectoryProcessing());
        }

        public void Select()
        {
            Console.WriteLine("1 - Вызвать метод 1\n2 - Вызвать метод 2\n3 - Вызвать метод 3\n4 - Вызвать метод 4");
            int number = Int32.Parse(Console.ReadLine());
            if (number > 0 && number <= menu.Count)
            {
                menu[number].ToDo(input.InputPath());
            }
            else
            {
                Console.WriteLine("Неправильный ввод");
            }
        }
    }
}