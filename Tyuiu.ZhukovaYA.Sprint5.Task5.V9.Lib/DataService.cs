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
                    double number = Convert.ToDouble(line[i].Replace('.', ','));
                        if (number > res && number % 1 == 0)
                        {
                            res = number;
                        }

                }
                return res;
            }
        }
    }
}
