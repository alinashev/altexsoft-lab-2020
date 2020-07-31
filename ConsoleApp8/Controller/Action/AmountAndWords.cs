namespace Task1
{
    public class AmountAndWords : Action
    {
        private View view;

        public AmountAndWords(View view)
        {
            this.view = view;
        }

        public void ToDo()
        {
            view.Amount();
        }
    }
}