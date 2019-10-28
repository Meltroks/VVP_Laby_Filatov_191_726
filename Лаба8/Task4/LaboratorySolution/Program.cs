using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaboratorySolution
{
    class Program
    {
        public class dot
        {
            public int x, y;
            public dot()
            {
                x = 0; y = 0;
            }

            public double length(dot n)
            {
                return Math.Sqrt( Math.Pow(n.x - x, 2) + Math.Pow(n.y - y, 2));
            }
        }

        static void Main(string[] args)
        {
            dot a = new dot
            {
                x = int.Parse(Console.ReadLine()),
                y = int.Parse(Console.ReadLine())
            };

            if (a.x > 0 && a.y > 0) Console.WriteLine("Quarter: I");
            else if (a.x > 0 && a.y < 0) Console.WriteLine("Quarter: IV");
            else if (a.x < 0 && a.y < 0) Console.WriteLine("Quarter: III");
            else if (a.x < 0 && a.y > 0) Console.WriteLine("Quarter: II");

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
