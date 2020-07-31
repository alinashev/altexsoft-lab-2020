using System;
using System.Collections.Generic;

namespace Task1
{
    public class Router
    {
        private View view;
        private Controller controller;
        private Dictionary<Int32, Action> menu = new Dictionary<int, Action>();

        public void setView(View view)
        {
            this.view = view;
        }

        public void SetController(Controller controller)
        {
            this.controller = controller;
        }
        public void GenerateMenu()
        {
            menu.Add(1, new WordRemover(view));
            menu.Add(2, new AmountAndWords(view));
            menu.Add(3, new PrintSentance(view));
            menu.Add(4, new DirectoryProcessing(view));
        }

        public void Select()
        {
            int number = Int32.Parse(Console.ReadLine());
            if (number > 0 & number <= menu.Count)
            {
                controller.PathInput();
                menu[number].ToDo();
            }
            else
            {
                view.WrongInput();
            }
        }
    }
}