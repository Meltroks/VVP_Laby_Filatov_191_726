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
            int a, b, c, s1, s2; // создание переменных

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            s1 = a * b; s2 = c * c;

            Console.WriteLine("Number of squares included: " + s1 / s2);
            Console.WriteLine("Unused area: " + s1 % s2);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
