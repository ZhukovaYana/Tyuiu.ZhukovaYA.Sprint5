using Tyuiu.ZhukovaYA.Sprint5.Task7.V19.Lib;

namespace Tyuiu.ZhukovaYA.Sprint5.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";
            string pathsave = ds.LoadDataAndSave(path);
            FileInfo fileInfo = new FileInfo(pathsave);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}