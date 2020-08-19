namespace Task2App
{
    public class MoveAddNewRecipe
    {
        private AddNewRecipe _addNewRecipe = new AddNewRecipe();
        private AddRecipe _addRecipe = new AddRecipe();
        private AddIngredients _addIngredients = new AddIngredients();

        public void AddRecipe()
        {
            _addRecipe.Name = _addNewRecipe.AddName();
            _addRecipe.Description = _addNewRecipe.AddDescription();
            _addRecipe.Steps = _addNewRecipe.AddStep();
            _addRecipe.Serialize(_addNewRecipe.GetPath(), _addRecipe);

            _addIngredients.Ingredients = _addNewRecipe.AddIngredients();
            _addIngredients.Serialize(_addNewRecipe.GetPathIng(), _addIngredients);
        }
    }
}