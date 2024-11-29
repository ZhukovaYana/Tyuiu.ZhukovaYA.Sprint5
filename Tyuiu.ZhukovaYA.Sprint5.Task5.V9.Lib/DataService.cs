using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhukovaYA.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double res = double.MinValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = reader.ReadToEnd().Split(' ');
                for (int i = 0; i < line.Length; i++)
                {
                    res = Convert.ToDouble(line[i].Replace('.', ','));
                    if (double.TryParse(line[i], out double number))
                    {
                        if (number > res)
                        {
                            res = number;
                        }
                    }

                }
                return res;
            }
        }
    }
}
