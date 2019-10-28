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
            int a, b, c; // создание переменных

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a < b && b < c) Console.WriteLine("A < B < C is TRUE");
            else Console.WriteLine("A < B < C is FALSE");

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
