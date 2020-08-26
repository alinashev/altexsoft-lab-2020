using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task2App
{
    public class Ingredient : IJsonEditor
    {
        public  Dictionary <string, string> Ingredients { get; set; } = new Dictionary<string, string>();
        public void Serialize(string path, object json)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(json, Formatting.Indented));
        }
    }
}