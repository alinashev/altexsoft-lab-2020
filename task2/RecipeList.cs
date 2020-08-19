using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Task2App
{
    public class RecipeList : Folder, IJsonToDictionary
    {
        private string _jsonString = ""; 
        private Dictionary<int , string> dictRecipeList = new Dictionary<int, string>();
        public void GenerateRecipeList(string select)
        {
            _jsonString = File.ReadAllText( base.GetPathFolder() + select + "Recipe" +  ".json");
        }
        
        public void JsonToDictionary()
        {
            JObject jsonObj = JObject.Parse(_jsonString);
            dictRecipeList = jsonObj.ToObject<Dictionary<int, string>>();
        }

        public void PrintDictionary()
        {
            Console.WriteLine(String.Join(' ', dictRecipeList));
        }
        public Dictionary<Int32, string> GetdictRecipeList()
        {
            return dictRecipeList;
        }
    }
}
