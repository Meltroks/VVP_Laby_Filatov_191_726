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
            int k, n; // создание переменных

            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            Console.WriteLine((k % 7 + n) - 1);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
