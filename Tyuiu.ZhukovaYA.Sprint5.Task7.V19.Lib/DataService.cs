using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhukovaYA.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string pathsave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V19.txt");
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadToEnd();
                line = line.Replace("сс","");
            }
            File.WriteAllText(pathsave, line);
            return pathsave;
        }
    }
}
