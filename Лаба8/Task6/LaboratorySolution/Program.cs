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
            String onedig = "однозначное ";
            String twodig = "двузначное ";
            String threedig = "трехзначное ";

            String even = "четное ";
            String uneven = "нечетное ";

            int n = -1;

            while (n < 1 || n > 999)
            {
                Console.WriteLine("Please input n in [1; 999] range!");
                n = int.Parse(Console.ReadLine());
            }

            if (n % 2 == 0) Console.Write(even);
            else Console.Write(uneven);

            if (n < 10) Console.Write(onedig);
            else if (n > 9 && n < 100) Console.Write(twodig);
            else if (n > 99 && n < 1000) Console.Write(threedig);

            Console.Write("число");

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
