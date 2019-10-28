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

            dot b = new dot
            {
                x = int.Parse(Console.ReadLine()),
                y = int.Parse(Console.ReadLine())
            };

            dot c = new dot
            {
                x = int.Parse(Console.ReadLine()),
                y = int.Parse(Console.ReadLine())
            };

            double len1 = b.length(a);
            double len2 = c.length(a);
            if (len1 < len2) Console.WriteLine("B, length = " + len1);
            else Console.WriteLine("C, length = " + len2);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
