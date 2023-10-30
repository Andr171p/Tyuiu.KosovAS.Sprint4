using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KosovAS.Sprint4.Task1.V7.Lib
{
    public class DataService : ISprint4Task1V7
    {
        public int Calculate(int[] array)
        {
            int result = 0;
            for (int i=  0;  i < array.Length; i++)
            {
                if ((array[i] > 8) && (array[i] < 1)) { return -1; }
                if (array[i] % 2 == 0)
                {
                    result += array[i];
                }
            }
            return result;
        }
    }
}
