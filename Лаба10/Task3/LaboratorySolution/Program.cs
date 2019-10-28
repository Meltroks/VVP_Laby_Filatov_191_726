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
            double n, ans = 1;

            n = double.Parse(Console.ReadLine());

            for(double i = 0; i <= n; i++)
            {
                ans += ((2 * i) - 1);
                Console.WriteLine(ans);
            }

            Console.WriteLine("N^2 = " + ans);
            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
