using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task2App
{ 
    public class AddIngredients : IJsonEditor
    {
        public Dictionary<string, Double> Ingredients { get; set; }

        public void Serialize(string path, object json)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(json, Formatting.Indented));
        }
    }
}
