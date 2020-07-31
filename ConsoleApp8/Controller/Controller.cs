using System;
using System.Reflection.PortableExecutable;

namespace Task1
{
    public class Controller
    {
        private string pathToFile;
        private Model model;
        private View view = new View();
        
        public void PathInput()
        { 
            view.PrintInfo();
            pathToFile = @"" + Console.ReadLine();
        }

        public void SetModel(Model model)
        {
            this.model = model;
        }
        public string GetPath()
        {
            return pathToFile;
        }

        public void RemoveWord()
        {
            string subString = Console.ReadLine();
            if (model.WordRemover(GetPath(),subString) == 0)
            {
                view.NoSubstring();
            }
        }

        public Model GetModel()
        {
            return model;
        }

        public void MoveDirectory()
        {
            model.DirectoryProcessing(pathToFile);
        }
    }
}