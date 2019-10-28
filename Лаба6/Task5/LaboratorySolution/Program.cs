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
            int n; // создание переменных

            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Decade of this year: " + ((n / 100) + 1));

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
