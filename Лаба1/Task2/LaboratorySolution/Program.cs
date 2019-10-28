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
            double d, pi = 3.14; // создание переменных
            d = int.Parse(Console.ReadLine()); // ввод переменных

            Console.WriteLine("L = " + d*pi); // вывод ответа

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
