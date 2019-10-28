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
            int a, b, tmp; // объявление переменных
            int c;

            a = int.Parse(Console.ReadLine()); // ввод переменных
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            tmp = c; c = a; a = b; b = tmp; // процедура обмена данных переменных

            Console.WriteLine(a + " " + b + " " + c); // вывод ответа

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
