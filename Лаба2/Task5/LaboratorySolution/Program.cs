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
            double x1, y1, x2, y2, x3, y3, l_12, l_23, l_13, p, hp, s; // создание переменных

            Console.WriteLine("Input x1, y1, x2, y2, x3, y3: ");
            x1 = double.Parse(Console.ReadLine()); // ввод переменных
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());

            l_12 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            l_23 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            l_13 = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            p = l_12 + l_13 + l_23;

            hp = (l_23 + l_13 + l_12) / 2;
            s = Math.Sqrt(hp * (hp - l_12) * (hp - l_23) * (hp - l_13));

            Console.WriteLine("P = " + p);
            Console.WriteLine("S = " + s);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
