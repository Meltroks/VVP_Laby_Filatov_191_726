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
            int a, b; // создание переменных
            a = int.Parse(Console.ReadLine()); // ввод переменных
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("S = " + a * b); // вывод ответа
            Console.WriteLine("P = " + 2 * (a + b)); 

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
