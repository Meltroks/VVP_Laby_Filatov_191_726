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
            double n, pi = 3.14; // инициализация переменных
            n = double.Parse(Console.ReadLine());

            Console.WriteLine(((n * 180) / pi) + " degrees."); // вывод ответа

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
