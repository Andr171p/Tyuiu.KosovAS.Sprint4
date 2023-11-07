using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint4.Task5.V16.Lib;

namespace Tyuiu.KosovAS.Sprint4.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,] { { 5, 7, -1 }, { 6, -3, -7 } };

            int[,] result = new int[,] { { 1, 1, -1 }, { 1, -3, -7 } };

            CollectionAssert.AreEqual(result, ds.Calculate(array));
        }
    }
}
