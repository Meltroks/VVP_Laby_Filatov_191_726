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

            if ((a*a + b*b == c*c) || (a*a + c*c == b*b) || (c*c + b*b == a*a)) Console.WriteLine("TRUE");
            else Console.WriteLine("FALSE");

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
