using System;

namespace Task1
{
    public class View
    {
        private Controller controller;
        private Router router;

        public void SetRouter(Router router)
        {
            this.router = router;
        }

        public void SetController(Controller controller)
        {
            this.controller = controller;
        }

        public void PrintMenu()
        {
            Console.WriteLine("1 - Вызвать метод 1\n2 - Вызвать метод 2\n3 - Вызвать метод 3\n4 - Вызвать метод 4");
            router.Select();
        }

        public void WrongInput()
        {
            Console.WriteLine("Неверный ввод");
            PrintMenu();
        }

        public void PrintInfo()
        {
            Console.WriteLine("Введите путь: ");
        }

        public void PrintWordRemuver()
        {
            Console.WriteLine("Подстрока, которую нужно вырезать:");
            controller.RemoveWord();
        }

        public void Amount()
        {
            Console.WriteLine(String.Join(',', controller.GetModel().GetModelAmount().AmountAndWords(controller.GetPath())));
        }
        public void SentencePrinter()
        {
            Console.WriteLine(String.Join(' ', controller.GetModel().GetModelSentance().PrintSentance(controller.GetPath())));
        }
        public void NoSubstring()
        {
            Console.WriteLine("Такой подстроки нет!");
        }

        public void PrintDirectory()
        {
            Console.WriteLine("Выберите папку: ");
            controller.MoveDirectory();
        }
    }
}