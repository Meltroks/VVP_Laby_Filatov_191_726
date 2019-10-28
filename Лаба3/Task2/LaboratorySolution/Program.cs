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
            int cil;

            a = int.Parse(Console.ReadLine()); // ввод переменных
            b = int.Parse(Console.ReadLine());
            cil = int.Parse(Console.ReadLine());

            tmp = cil; cil = b; b = a; a = tmp; // процедура обмена данных переменных

            Console.WriteLine(a + " " + b + " " + cil); // вывод ответа

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
