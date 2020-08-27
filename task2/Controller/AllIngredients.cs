﻿﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Task2App
{
    public class AllIngredients
    {
        private  FileWriter _fileWriter = new FileWriter();
        public void AddIngredientsToAllList(Dictionary<string, string> currentIngredients, string directoryPath)
        {
            Dictionary<string, string> allFromJson =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(directoryPath));
            currentIngredients.ToList().ForEach(x => allFromJson.Add(x.Key, x.Value));
            _fileWriter.Serialize(directoryPath, allFromJson);
        }
    }
}