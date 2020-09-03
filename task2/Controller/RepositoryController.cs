using System.IO;

namespace Task2App
{
    public class RepositoryController : IRepository
    {
        private PathRecipe _pathRecipe = new PathRecipe();
        private NewRecipe _newrecipe;
        private Recipe _recipe = new Recipe();
        private Ingredient _ingredient = new Ingredient();
        private FileWriter _fileWriter = new FileWriter();
        private string path;

        public void Add(string directoryName)
        {
            if (Directory.Exists(directoryName))
            {
                path = _pathRecipe.GeneratePath(directoryName);
                _recipe.Name = _pathRecipe.name;
                _newrecipe = new NewRecipe(path);
                _recipe.Description = _newrecipe.AddDescription();
                _recipe.Steps = _newrecipe.AddStep();
                _fileWriter.Serialize(path + @"\" + _pathRecipe.name + @".json", _recipe);

                _ingredient.dictionaryIngredients = _newrecipe.AddIngredients();
                _fileWriter.Serialize(path + @"\" + _pathRecipe.name + @"Ingredients.json", _ingredient);
            }
        }
    }
}