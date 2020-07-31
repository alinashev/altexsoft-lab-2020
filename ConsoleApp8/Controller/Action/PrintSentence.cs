namespace Task1
{
    public class PrintSentance : Action
    {
        private View view;

        public PrintSentance(View view)
        {
            this.view = view;
        }

        public void ToDo()
        {
            view.SentencePrinter();
        }
    }
}