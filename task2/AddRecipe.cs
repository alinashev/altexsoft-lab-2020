using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task2App
{
    public class AddRecipe: IJsonEditor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Steps { get; set; }
        
        
        public void Serialize(string path, object json)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(json, Formatting.Indented));
        }
        
    }
}