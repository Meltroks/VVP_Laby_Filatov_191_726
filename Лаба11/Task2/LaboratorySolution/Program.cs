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
            int a, b, suma = 0;
            Console.Write("A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            b = int.Parse(Console.ReadLine());

            while(suma + b <= a)
            {
                suma += b;
            }

            Console.WriteLine("Длина незанятой части отрезка А: " + (a - suma));

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
