namespace Task1
{
    public class Model
    {
        ModelAmount modelAmount = new ModelAmount();
        ModelDirectory modelDirectory = new ModelDirectory();
        ModelRemover modelRemover = new ModelRemover();
        ModelSentance modelSentance = new ModelSentance();

        public ModelAmount GetModelAmount()
        {
            return modelAmount;
        }

        public ModelDirectory GetMeodelDirectory()
        {
            return modelDirectory;
        }

        public ModelRemover GetModelRemover()
        {
            return modelRemover;
        }

        public ModelSentance GetModelSentance()
        {
            return modelSentance;
        }
    }
}