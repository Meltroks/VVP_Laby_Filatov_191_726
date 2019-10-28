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
            double a, b; // создание переменных
            a = int.Parse(Console.ReadLine()); // ввод переменных
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("(a+b)/2 = " + (a+b)/2); // вывод ответа

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
