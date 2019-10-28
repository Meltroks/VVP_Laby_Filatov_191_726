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
            int n, tmp; // создание переменных

            n = int.Parse(Console.ReadLine());

            Console.Write(n % 10);
            Console.Write(n / 10);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
