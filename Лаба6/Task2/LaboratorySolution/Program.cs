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
            int k; // создание переменных

            k = int.Parse(Console.ReadLine());
            // n = int.Parse(Console.ReadLine());

            Console.WriteLine(k % 7);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
