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

            if (a > 2 && b <= 3) Console.WriteLine("A > 2 and B <= 3 is TRUE");
            else Console.WriteLine("A > 2 and B <= 3 is FALSE");

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
