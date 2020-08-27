﻿using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task2App
{
    public class Ingredient
    {
        public  Dictionary <string, string> dictionaryIngredients { get; set;} = new Dictionary<string, string>();
    }
}