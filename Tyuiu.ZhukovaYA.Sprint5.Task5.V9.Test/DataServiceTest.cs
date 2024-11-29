using Tyuiu.ZhukovaYA.Sprint5.Task5.V9.Lib;

namespace Tyuiu.ZhukovaYA.Sprint5.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"С:/DataSprint5/InPutDataFileTask5V9.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}