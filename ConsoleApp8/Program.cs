namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Controller controller = new Controller();
            View view = new View();
            Model model = new Model();
            Router router = new Router();
            router.setView(view);
            router.SetController(controller);
            router.GenerateMenu();
            controller.SetModel(model);
            view.SetController(controller);
            view.SetRouter(router);
            view.PrintMenu();
        }
    }
}