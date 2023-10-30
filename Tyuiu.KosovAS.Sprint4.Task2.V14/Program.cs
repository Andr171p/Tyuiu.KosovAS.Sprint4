using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KosovAS.Sprint4.Task2.V14.Lib;

namespace Tyuiu.KosovAS.Sprint4.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Косов А. С. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #4" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант 7" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Выполнил: Косов Андрей Сергеевич | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая суммирует количевство четных чисел в массиве *");
            Console.WriteLine("* и печатает их на экран.                                                 *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("Введите количевство элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i < len - 1; i++)
            {
                array[i] = rnd.Next(1, 8);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine($"* Результат:{String.Concat(Enumerable.Repeat(" ", 62))}*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine($"Произведение нечетных элементов массива: \n{ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
