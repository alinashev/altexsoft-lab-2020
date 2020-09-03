﻿﻿using System;
using System.Collections.Generic;

namespace Task2App
{
   public class NewRecipe
    {
        private string _name;
        private string _description;
        private string _step;
        private string[] _pathBlocks;
        private UpdaterAllIngredients _allIngredients = new UpdaterAllIngredients(new FileWriter());
        private Dictionary<string, string> dictIngredients = new Dictionary<string, string>();
        
        public NewRecipe(){}
        public NewRecipe(string pathRecipe)
        {
            _pathBlocks = pathRecipe.Split(@"\");
        }
        
        public string AddName()
        {
            Console.WriteLine("\nAdd Name: ");
            _name = Console.ReadLine();
            return _name;
        }
        
        public string AddDescription()
        {
            Console.WriteLine("Add Description: ");
            _description = Console.ReadLine();
            return _description;
        }

        public string AddStep()
        {
            Console.WriteLine("AddStep: ");
            _step = Console.ReadLine();
            return _step;
        }

        public Dictionary<string, string> AddIngredients()
        {
            string nameIngredient;
            string amountIngredient;
            Console.WriteLine("Add amount ingredients: ");
            try
            {
                int count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add Ingredients (name Ingredient/amount Ingredient: ");
                for (int i = 0; i < count; i++)
                {
                    nameIngredient = Console.ReadLine();
                    amountIngredient = Console.ReadLine();
                    if (!dictIngredients.ContainsKey(nameIngredient))
                    {
                        dictIngredients.Add(nameIngredient, amountIngredient);
                    }
                }
            
                _allIngredients.AddIngredientsToAllList(dictIngredients, AppDomain.CurrentDomain.BaseDirectory + _pathBlocks[0] + @"\AllIngredient.json");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input. Try again");
                AddIngredients();
            }
            return dictIngredients;
        }
        
    }
}