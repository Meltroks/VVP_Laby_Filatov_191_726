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

            a = int.Parse(Console.ReadLine()); // ввод переменных
            b = int.Parse(Console.ReadLine());

            tmp = a; a = b; b = tmp; // процедура обмена данных переменных

            Console.WriteLine(a + " " + b); // вывод ответа

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
