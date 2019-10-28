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
            tmp = a % 10;
            a /= 10;

            if(a%10 < tmp)
            {
                while (a > 0)
                {
                    if(a%10 < tmp)
                    {
                        tmp = a % 10;
                        a /= 10;
                    }
                    else
                    {
                        count++;
                        tmp = a % 10;
                        a /= 10;
                    }
                }
                if (count == 0) Console.WriteLine("TRUE");
                else Console.WriteLine("FALSE");
            }
            else
            {
                while (a > 0)
                {
                    if (a % 10 > tmp)
                    {
                        tmp = a % 10;
                        a /= 10;
                    }
                    else
                    {
                        count++;
                        tmp = a % 10;
                        a /= 10;
                    }
                }
                if (count == 0) Console.WriteLine("TRUE");
                else Console.WriteLine("FALSE");
            }

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
