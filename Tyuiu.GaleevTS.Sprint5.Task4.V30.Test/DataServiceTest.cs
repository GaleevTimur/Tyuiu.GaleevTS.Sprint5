using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint5.Task4.V30.Lib;
using System.IO;

namespace Tyuiu.GaleevTS.Sprint5.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\timur_8n182p8\source\repos\Tyuiu.GaleevTS.Sprint5\Tyuiu.GaleevTS.Sprint5.Task4.V30\bin\Debug\InPutDataFileTask4V30.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
