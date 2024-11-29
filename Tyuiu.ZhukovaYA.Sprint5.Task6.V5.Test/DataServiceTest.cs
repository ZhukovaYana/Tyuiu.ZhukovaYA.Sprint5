using Tyuiu.ZhukovaYA.Sprint5.Task6.V5.Lib;

namespace Tyuiu.ZhukovaYA.Sprint5.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V5.txt";
            int res = ds.LoadFromDataFile(path);
            int wait = 7;

            Assert.AreEqual(wait, res);
        }
    }
}