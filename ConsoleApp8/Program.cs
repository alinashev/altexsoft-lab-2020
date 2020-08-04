namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Input input = new Input();
            Router router = new Router(input);
            router.GenerateMenu();
            router.Select();
        }
    }
}