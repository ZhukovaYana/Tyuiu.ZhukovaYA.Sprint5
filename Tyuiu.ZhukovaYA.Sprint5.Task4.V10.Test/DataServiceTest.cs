using Tyuiu.ZhukovaYA.Sprint5.Task4.V10.Lib;

namespace Tyuiu.ZhukovaYA.Sprint5.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Win\AppData\Local\Temp\OutPutFileTask4.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}