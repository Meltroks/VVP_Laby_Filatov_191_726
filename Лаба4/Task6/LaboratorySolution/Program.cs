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
            double a1, a2, b1, b2, c1, c2, x, y; // объявление переменных

            a1 = double.Parse(Console.ReadLine()); // ввод переменных
            b1 = double.Parse(Console.ReadLine());
            c1 = double.Parse(Console.ReadLine());
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine()); // x = (c1 - b1*y)/a1
            c2 = double.Parse(Console.ReadLine()); // a2 *((c1 - b1*y)/a1) + b2*y = c2
            // 



            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
