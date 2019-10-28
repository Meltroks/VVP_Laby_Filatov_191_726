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
            double x, a, y, kilo; // инициализация переменных

            x = double.Parse(Console.ReadLine()); // ввод переменных
            a = double.Parse(Console.ReadLine());

            kilo = a / x;

            Console.WriteLine("1 kg price: " + kilo);
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("Y kg price: " + kilo*y);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
