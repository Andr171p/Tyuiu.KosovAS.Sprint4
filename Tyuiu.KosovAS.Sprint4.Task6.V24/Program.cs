using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KosovAS.Sprint4.Task6.V24.Lib;

namespace Tyuiu.KosovAS.Sprint4.Task6.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Косов А. С. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #4" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант 24" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Выполнил: Косов Андрей Сергеевич | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая выводит на экран элементы массива длина      *");
            Console.WriteLine("* которых больше 7.                                                       *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("Исходный массив: ");
            string[] array = new string[] { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine($"* Результат:{String.Concat(Enumerable.Repeat(" ", 62))}*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            for (int i = 0; i < ds.Calculate(array).Length; i++)
            {
                Console.WriteLine(ds.Calculate(array)[i]);
            }
            Console.ReadKey();

        }
    }
}
