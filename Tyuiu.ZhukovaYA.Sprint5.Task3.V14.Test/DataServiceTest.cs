﻿using Tyuiu.ZhukovaYA.Sprint5.Task3.V14.Lib;

namespace Tyuiu.ZhukovaYA.Sprint5.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string strRes = ds.SaveToFileTextData(3);
            string path = @"C:\Users\Win\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}