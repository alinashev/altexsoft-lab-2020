namespace Task2App
{
    public class FileWriter
    {
        private List<string> _dirsList = new List<string>();
        public void Serialize(string path, object json)
        {
            if (CheckDirectory(path))
            {
                WriteAllText(path, JsonConvert.SerializeObject(json, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Path does not exist");
            }
            
        }
        private bool CheckDirectory(string path)
        {
            string[] _dirsAndFiles = path.Split(@"\");
            for (int i = 0; i < _dirsAndFiles.Length-1; i++)
            {
                _dirsList.Add(_dirsAndFiles[i]);
            }

            string checkedPath = string.Join(@"\", _dirsList);
            checkedPath = checkedPath.Substring(checkedPath.Length / 2);
            if (Directory.Exists(checkedPath))
            {
                return false;
            }
            return true;
        }
    }
}