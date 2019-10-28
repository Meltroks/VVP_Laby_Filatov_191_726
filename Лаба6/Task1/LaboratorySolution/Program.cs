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

            Console.WriteLine(n % 60);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
