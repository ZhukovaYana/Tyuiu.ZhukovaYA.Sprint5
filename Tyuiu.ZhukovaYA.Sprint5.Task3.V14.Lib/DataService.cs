using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhukovaYA.Sprint5.Task3.V14.Lib
{
    public class DataService : ISprint5Task3V14
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double res = (double)(4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(Math.Round(res, 3)));
            }
            return path;
        }
    }
}
