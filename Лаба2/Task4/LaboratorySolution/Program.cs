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
            double x1, y1, x2, y2, a, b; // создание переменных

            Console.WriteLine("Input x1, y1, x2, y2: ");
            x1 = double.Parse(Console.ReadLine()); // ввод переменных
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            a = Math.Abs(x2 - x1); // вычисление сторон прямоугольника
            b = Math.Abs(y2 - y1);

            Console.WriteLine("P = " + 2 * (a + b));
            Console.WriteLine("S = " + (a * b));

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
