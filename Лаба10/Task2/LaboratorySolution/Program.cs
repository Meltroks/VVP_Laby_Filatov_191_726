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
            double n, ans = 1.0;

            n = double.Parse(Console.ReadLine());

            for(double i = 1; i <=n; i++)
            {
                ans *= (1 + (i/10));
            }

            Console.WriteLine(ans);
            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
