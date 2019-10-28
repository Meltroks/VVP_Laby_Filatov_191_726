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
            int a, b; // создание переменных

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                a = 0;
                b = 0;
            }
            else
            {
                if (a > b) b = a;
                else a = b;
            }

            Console.WriteLine(a + " " + b);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
