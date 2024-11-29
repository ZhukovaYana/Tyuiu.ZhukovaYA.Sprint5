using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhukovaYA.Sprint5.Task6.V5.Lib
{
    public class DataService : ISprint5Task6V5
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader sr = new StreamReader(path)) 
            { 
                string line = sr.ReadToEnd();
                for (int i = 0; i < line.Length; i++)
                {
                    if (Char.IsUpper(line[i]) && Char.IsLetter(line[i]))
                    {
                        res++;
                    }
                }
            }
            return res;
        }
    }
}
