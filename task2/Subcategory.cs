using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Task2App
{
    public class Subcategory: Folder, IJsonToDictionary
    {
        private string jsonString = ""; 
        private Dictionary<Int32 , string> dictSubcaregory = new Dictionary<Int32, string>();
        public void GenerateSubCategory(string select)
        {
            jsonString = File.ReadAllText(base.GetPathFolder() + select + "Subcategory" +  ".json");
        }
        
        public void JsonToDictionary()
        {
            JObject jsonObj = JObject.Parse(jsonString);
            dictSubcaregory = jsonObj.ToObject<Dictionary<int, string>>();
        }

        public void PrintDictionary()
        {
            Console.WriteLine(String.Join(' ', dictSubcaregory));
        }
        public Dictionary<Int32, string> GetdictSubcaregory()
        {
            return dictSubcaregory;
        }
        
    }
}