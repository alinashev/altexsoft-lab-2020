namespace Task1
{
    public class DirectoryProcessing : Action
    {
        private View view;

        public DirectoryProcessing(View view)
        {
            this.view = view;
        }

        public void ToDo()
        {
            view.PrintDirectory();
        }
    }
}