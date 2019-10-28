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
            int a, b, c, sum1, sum2, sum3; // создание переменных

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            sum1 = a + b;
            sum2 = b + c;
            sum3 = a + c;

            Console.WriteLine(Math.Max(sum1, Math.Max(sum2, sum3)));


            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
