using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint4.Task7.V1.Lib;

namespace Tyuiu.KosovAS.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string value = "135792468";

            Assert.AreEqual(20, ds.Calculate(3, 3, value));
        }
    }
}
