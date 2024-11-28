using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhukovaYA.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                //if (x == 0)
                //{
                //    File.AppendAllText(path, "0" + Environment.NewLine);
                //    continue;
                //}
                y = (Math.Sin(x)/(x+1.7)) - Math.Cos(x)*4*x-6;
                y = Math.Round(y, 2);

                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }

            }
            return path;
        }
    }
}
