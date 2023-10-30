using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint4.Task1.V7.Lib;

namespace Tyuiu.KosovAS.Sprint4.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };

            Assert.AreEqual(24, ds.Calculate(array));
        }
    }
}
