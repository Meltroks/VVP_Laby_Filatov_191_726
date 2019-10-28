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
            y = 4*Math.Pow((x-3), 6) - 7*Math.Pow((x-3), 3) + 2; // вычисление задания
            Console.WriteLine("4(x-3)^6 - 7(x-3)^3 + 2 = " + y); // вывод

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
