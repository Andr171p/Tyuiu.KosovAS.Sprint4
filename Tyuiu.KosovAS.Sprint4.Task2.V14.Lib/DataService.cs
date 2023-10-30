﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KosovAS.Sprint4.Task2.V14.Lib
{
    public class DataService : ISprint4Task2V14
    {
        public int Calculate(int[] array)
        {
            int result = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    result *= array[i];
                }
            }
            return result;
        }
    }
}
