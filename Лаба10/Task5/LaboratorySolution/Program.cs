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
            double n, a, mult = 1, ans = 1;

            Console.Write("A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("N: ");
            n = double.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                ans = ans + (mult * (-1))*Math.Pow(a, i);
            }

            Console.WriteLine("Answer: " + ans);
            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
