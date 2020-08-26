using System.IO;

namespace Task2App
{
    public class MoveAddRecipe : IAction
    {
        private PathRecipe _pathRecipe = new PathRecipe();
        private NewRecipe _newrecipe;
        private Recipe _recipe = new Recipe();
        private Ingredient _ingredient = new Ingredient();
        private string path;
        
        public void ToDo(string directoryName)
        {
            if (Directory.Exists(directoryName))
            {
                path = _pathRecipe.GeneratePath(directoryName);
                _recipe.Name = _pathRecipe.name;
                _newrecipe = new NewRecipe(path);
                _recipe.Description = _newrecipe.AddDescription();
                _recipe.Steps = _newrecipe.AddStep();
                _recipe.Serialize(path + @"\" + _pathRecipe.name + @".json", _recipe);

                _ingredient.Ingredients = _newrecipe.AddIngredients();
                _ingredient.Serialize(path + @"\" + _pathRecipe.name + @"Ingredients.json", _ingredient);
            }
        }
    }
}