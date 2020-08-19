using System;

namespace Task2App
{
    public class MoveCategory: IAction
    {
        private Category _category = new Category();
        private Subcategory _subcategory = new Subcategory();
        private RecipeList _recipeList = new RecipeList();
        private PrintRecipe _printRecipe = new PrintRecipe();

        public void ToDo()
        {
            _category.JsonToDictionary();
            _category.PrintDictionary();
            
            _subcategory.GenerateSubCategory(ChoiceCategory());
            _subcategory.JsonToDictionary();
            _subcategory.PrintDictionary();
            
            _recipeList.GenerateRecipeList(ChoiceSubCategory());
            _recipeList.JsonToDictionary();
            while (true)
            {
                Console.WriteLine("Добавить новый рецепт? Y - да, N - нет");
                string input = Console.ReadLine();
                if (input.Equals("Y"))
                {
                    new MoveAddNewRecipe().AddRecipe();  
                }
                else if(input.Equals("N"))
                {
                    _recipeList.PrintDictionary();
                    Console.WriteLine("Сделайте выбор рецепта");
                    _printRecipe.GenerateRecipe(ChoiceRecipe());
                    _printRecipe.JsonToDictionary();
                    _printRecipe.PrintDictionary();
                    break;
                }
            }
            
        }
        public string ChoiceCategory()
        {
            return _category.GetDictObj()[Int32.Parse(Console.ReadLine())];
        }
        public string ChoiceSubCategory()
        {
            return _subcategory.GetdictSubcaregory()[Int32.Parse(Console.ReadLine())];
        }

        public string ChoiceRecipe()
        {
            return _recipeList.GetdictRecipeList()[Int32.Parse(Console.ReadLine())];
        }
    }
}