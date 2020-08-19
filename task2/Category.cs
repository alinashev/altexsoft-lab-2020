using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Task2App
{
    public class Category : Folder, IJsonToDictionary
    {
        private string _jsonString;
        private Dictionary<Int32, string> dictObj = new Dictionary<Int32, string>();
        public Category()
        {
            _jsonString =File.ReadAllText( base.GetPathFolder() + "category.json");
        }
        public Dictionary<Int32, string> GetDictObj()
        {
            return dictObj;
        }

        public void JsonToDictionary()
        {
            JObject jsonObj = JObject.Parse(_jsonString);
            dictObj = jsonObj.ToObject<Dictionary<Int32, string>>();
        }

        public void PrintDictionary()
        {
            Console.WriteLine(String.Join(' ', dictObj));
        }
    }
    
}