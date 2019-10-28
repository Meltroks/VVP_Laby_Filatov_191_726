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
            double v1, v2, s, t, ans; // инициализация переменных

            v1 = double.Parse(Console.ReadLine()); // ввод переменных
            v2 = double.Parse(Console.ReadLine());
            s = double.Parse(Console.ReadLine());
            t = double.Parse(Console.ReadLine());

            ans = s + (v1 * t) + (v2 * t);

            Console.WriteLine("S = " + ans);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
