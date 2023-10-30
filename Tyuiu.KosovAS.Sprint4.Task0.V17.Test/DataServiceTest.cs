using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint4.Task0.V17.Lib;

namespace Tyuiu.KosovAS.Sprint4.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

            Assert.AreEqual(7, ds.GetSumEvenArrEl(array));
        }
    }
}
