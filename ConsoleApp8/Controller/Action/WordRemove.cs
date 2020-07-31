namespace Task1
{
    public class WordRemover : Action
    {
        private View view;

        public WordRemover(View view)
        {
            this.view = view;
        }

        public void ToDo()
        {
            view.PrintWordRemuver();
        }
    }
}