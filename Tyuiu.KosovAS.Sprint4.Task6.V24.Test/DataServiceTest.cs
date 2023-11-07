using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint4.Task6.V24.Lib;

namespace Tyuiu.KosovAS.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };

            string[] res = new string[] { "Компьютер", "Клавиатура" };

            CollectionAssert.AreEqual(res, ds.Calculate(array));
        }
    }
}
