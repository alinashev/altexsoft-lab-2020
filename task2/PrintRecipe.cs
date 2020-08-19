using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Task2App
{
    public class PrintRecipe: Folder, IJsonToDictionary
    {
        private PrintRecipe _printRecipe;
        private string _jsonStringRecipe = ""; 
        private string _jsonStringRecipeIngredient = ""; 
        
        private Dictionary<string , string> dictRecipe = new Dictionary<string, string>();
        private Dictionary<string , Double> dictRecipeIngridients = new Dictionary<string, Double>();
        
        public void GenerateRecipe(string select)
        {
            _jsonStringRecipe = File.ReadAllText( base.GetPathFolder() + select + ".json");
            _jsonStringRecipeIngredient = File.ReadAllText( base.GetPathFolder() + select + "Ingredients" + ".json");
        }
        
        public void JsonToDictionary()
        {
            JObject jsonObj = JObject.Parse(_jsonStringRecipe);
            dictRecipe = jsonObj.ToObject<Dictionary<string, string>>();
            JObject jsonObjIngredients = JObject.Parse(_jsonStringRecipeIngredient);
            dictRecipeIngridients = jsonObjIngredients.ToObject<Dictionary<string, Double>>();
        }

        public void PrintDictionary()
        {
            Console.WriteLine(String.Join(' ', dictRecipe));
            Console.WriteLine(String.Join(' ', dictRecipeIngridients));
        }
        
        public Dictionary<string, string> GetdictRecipe()
        {
            return dictRecipe;
        }
        public Dictionary<string, Double> GetdictRecipeIngredients()
        {
            return dictRecipeIngridients;
        }
    }
}