using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaboratorySolution
{
    class Program
    {
        static public int Quarter(int x, int y)
        {
            if (x > 0 && y > 0) return 1;
            else if (x > 0 && y < 0) return 4;
            else if (x < 0 && y < 0) return 3;
            else return 2;
        }

        static void Main(string[] args)
        {
            int xin, yin;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("X: ");
                xin = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                yin = int.Parse(Console.ReadLine());

                Console.WriteLine("Координатная четверть: " + Quarter(xin, yin));
            }

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
