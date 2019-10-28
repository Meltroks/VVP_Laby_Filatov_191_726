using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaboratorySolution
{
    class Program
    {
        static public double RingS(double R1, double R2)
        {
            return ((R1 * R1 * 3.14) - (R2 * R2 * 3.14));
        }

        static void Main(string[] args)
        {
            int rbig, rsmall;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("R большое: ");
                rbig = int.Parse(Console.ReadLine());
                Console.Write("R малое: ");
                rsmall = int.Parse(Console.ReadLine());

                Console.WriteLine("S кольца: " + RingS(rbig, rsmall));
            }

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
