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
            if (a < 0) a = a * (-1);
            if (b < 0) b = b * (-1);

            Console.WriteLine("a + b = " + (a + b)); // вывод ответа
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
