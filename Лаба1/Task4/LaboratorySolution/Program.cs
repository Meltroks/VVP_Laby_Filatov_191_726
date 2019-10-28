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

            Console.WriteLine("a^2 + b^2 = " + (a*a) + (b*b)); // вывод ответа
            Console.WriteLine("a^2 - b^2 = " + ((a * a) - (b * b)) );
            Console.WriteLine("a^2 * b^2 = " + ((a * a) * (b * b)) );
            Console.WriteLine("a^2 / b^2 = " + ((a * a) / (b * b)) );

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
