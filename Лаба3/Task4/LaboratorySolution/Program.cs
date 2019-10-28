using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaboratorySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x; // объявление переменных

            x = double.Parse(Console.ReadLine()); // ввод
            y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7; // вычисление задания
            Console.WriteLine("3x^6 - 6x^2 - 7 = " + y); // вывод

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
