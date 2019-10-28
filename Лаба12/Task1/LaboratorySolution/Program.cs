using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaboratorySolution
{
    class Program
    {
        static public double PowerA3(double a, double b)
        {
            b = a * a * a;
            return b;
        }

        static void Main(string[] args)
        {
            double ain, bin;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("TEST " + (i+1));
                Console.Write("A: ");
                ain = double.Parse(Console.ReadLine());
                Console.Write("B: ");
                bin = double.Parse(Console.ReadLine());

                Console.WriteLine(PowerA3(ain, bin));
            }


            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
