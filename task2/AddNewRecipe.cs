using System;
using System.Collections.Generic;
using System.Text;

namespace Task2App
{
    public class AddNewRecipe : Folder 
    {
        private StringBuilder _path = new StringBuilder();
        private StringBuilder _pathIng = new StringBuilder();
        private string _name;
        private string _description;
        private string _step;
        private Dictionary<string, Double> dictIngredients = new Dictionary<string, Double>();
        
        
        public string AddName()
        {
            Console.WriteLine("\nВведите название: ");
            _name = Console.ReadLine();
            _path.Append(GetPathFolder()).Append(_name).Append(".json");
            _pathIng.Append(GetPathFolder()).Append(_name).Append("Ingredient.json");
            return _name;
        }

        public string AddDescription()
        {
            Console.WriteLine("Описание: ");
            _description = Console.ReadLine();
            return _description;
        }

        public string AddStep()
        {
            Console.WriteLine("Описание Шагов: ");
            _step = Console.ReadLine();
            return _step;
        }

        public Dictionary<string, Double> AddIngredients()
        {
            Console.WriteLine("Введите количество ингридиентов: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ингредиенты (Ингредиент/Коллличество: ");
            for (int i = 0; i < count; i++)
            {
                dictIngredients.Add(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
            }
            return dictIngredients;
        }
       
        public string GetPath(){
            return _path.ToString();
        }
        
        public string GetPathIng(){
            return _pathIng.ToString();
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetStep()
        {
            return _step;
        }
        public Dictionary<string, Double> GetIngredients()
        {
            return dictIngredients;
        }
    }
}