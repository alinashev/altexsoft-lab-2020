using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Task2App
{
    public class AllIngredients : IJsonEditor
    {
        public void AddIngredientsToAllList(Dictionary<string, string> currentIngredients, string directoryPath)
        {
            Dictionary<string, string> allFromJson =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(directoryPath));
            currentIngredients.ToList().ForEach(x => allFromJson.Add(x.Key, x.Value));
            Serialize(directoryPath, allFromJson);
        }

        public void Serialize(string path, object json)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(json, Formatting.Indented));
        }
    }
}