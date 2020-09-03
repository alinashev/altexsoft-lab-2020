﻿﻿using System.IO;

namespace Task2App
{
    public class MoveAddRecipe : IAction
    {
        private RepositoryController _repositoryController = new RepositoryController();
        public void ToDo(string directoryName)
        {
            _repositoryController.Add(directoryName);
        }
    }
}