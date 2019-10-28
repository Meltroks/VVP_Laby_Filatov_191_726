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
            int a, tmp, count = 0; // создание переменных

            a = int.Parse(Console.ReadLine());
            tmp = a;

            while(tmp > 0)
            {
                tmp /= 10;
                count++;
            }

            if (a % 2 == 0 && count == 2) Console.WriteLine("Number is even and has two digits - TRUE");
            else Console.WriteLine("Number is even and has two digits - FALSE");

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
