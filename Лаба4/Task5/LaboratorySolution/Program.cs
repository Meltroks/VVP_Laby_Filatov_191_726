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
            double x, a, b; // объявление переменных
            a = double.Parse(Console.ReadLine()); // ввод переменных
            if (a == 0)
            {
                while (a == 0)
                {
                    Console.Write("Input A != 0: ");
                    a = double.Parse(Console.ReadLine());
                }
            }
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("x = " + ((b * (-1)) / a));


            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
