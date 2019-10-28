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
            int n, count = 0, tmp = 0;

            n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                count += i;
                if (count >= n)
                {
                    tmp = i;
                    break;
                }
            }


            Console.WriteLine("Число: " + tmp);
            Console.WriteLine("Сумма: " + count);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
