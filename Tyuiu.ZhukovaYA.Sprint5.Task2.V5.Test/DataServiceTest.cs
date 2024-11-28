using Tyuiu.ZhukovaYA.Sprint5.Task2.V5.Lib;

namespace Tyuiu.ZhukovaYA.Sprint5.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { 9, 6, 6 }, { 8, 7, 2 }, { 1, 7, 8 } };
            string strRes = ds.SaveToFileTextData(matrix);
            string path = @"C:\Users\Win\AppData\Local\Temp\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}