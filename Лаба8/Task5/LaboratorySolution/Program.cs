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
            String pos = "положительное ";
            String unpos = "отрицательное ";

            String even = "четное ";
            String uneven = "нечетное ";

            String zero = "нулевое ";

            int n;

            n = int.Parse(Console.ReadLine());

            if (n != 0)
            {
                if (n > 0) Console.Write(pos);
                else Console.Write(unpos);

                if (n % 2 == 0) Console.Write(even);
                else Console.Write(uneven);
            }
            else Console.Write(zero);

            Console.Write("число");

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
