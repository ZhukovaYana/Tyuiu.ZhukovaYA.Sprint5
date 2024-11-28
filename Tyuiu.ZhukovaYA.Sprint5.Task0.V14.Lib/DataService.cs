using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhukovaYA.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double res = (4*Math.Pow(x,3) ) / (Math.Pow(x,3) - 1);
            File.WriteAllText(path, Math.Round(res, 3).ToString());
            return path;
        }
    }
}
