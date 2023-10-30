using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint4.Task2.V14.Lib;

namespace Tyuiu.KosovAS.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 1, 3, 6, 8, 3 };

            Assert.AreEqual(9, ds.Calculate(array));
        }
    }
}
