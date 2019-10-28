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
            double n, tmp; // цена конфет

            n = double.Parse(Console.ReadLine());

            for(double i = 1; i <=10; i++)
            {
                tmp = n * (i / 10);
                Console.WriteLine("Цена за " + i / 10 + " кг конфет: " + tmp);
            }

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
