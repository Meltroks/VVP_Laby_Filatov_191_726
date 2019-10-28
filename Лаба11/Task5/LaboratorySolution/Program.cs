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

            int n1, n2;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            while (n1 != 0 && n2 != 0)
            {
                if (n1 > n2) n1 -= n2;
                else n2 -= n1;
            }

            Console.WriteLine(Math.Max(n1, n2));

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
