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
            double a, b, c, ac, bc; // создание переменных

            a = double.Parse(Console.ReadLine()); // ввод переменных
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            ac = Math.Abs(c - a);
            bc = Math.Abs(c - b);
            Console.WriteLine("AC length = " + ac);
            Console.WriteLine("BC length = " + bc);
		 Console.WriteLine("AC + BC length = " + (ac + bc));

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
