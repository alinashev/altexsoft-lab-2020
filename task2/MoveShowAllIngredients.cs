namespace Task2App
{
    public class MoveShowAllIngredients: IAction

    {
    private Ingredients _ingredients = new Ingredients();

    public void ToDo()
    {
        _ingredients.JsonToDictionary();
        _ingredients.PrintDictionary();
    }
    }
}