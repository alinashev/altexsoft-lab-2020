using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Task2App
{
    public class Ingredients: Folder, IJsonToDictionary
    {
        private string _jsonString;
        private Dictionary<string, Double> dictIngredients = new Dictionary<string, Double>();

       public Ingredients()
        {
            _jsonString = File.ReadAllText( base.GetPathFolder() + "AllIngredient.json");
        }

        public Dictionary<string, Double> GetDictIngredients()
        {
            return dictIngredients;
        }

        public void JsonToDictionary()
        {
            JObject jsonObj = JObject.Parse(_jsonString);
            dictIngredients = jsonObj.ToObject<Dictionary<string, Double>>();
        }

        public void PrintDictionary()
        {
            Console.WriteLine(String.Join(' ',dictIngredients));
        }
    }
}