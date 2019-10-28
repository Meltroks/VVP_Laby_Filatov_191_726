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
            double x1, x2, y1, y2, ans, inter1, inter2; // создание переменных

            x1 = double.Parse(Console.ReadLine()); // ввод переменных
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            inter1 = x2 - x1;
            inter2 = y2 - y1;
            ans = Math.Sqrt(inter1 * inter1 + inter2 * inter2);

            Console.WriteLine("Length: " + ans);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
