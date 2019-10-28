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

            int n, k = 1, tmp;
            int num_back = 0, num_front = 1;

            n = int.Parse(Console.ReadLine());

            while(num_front <= n)
            {
                if (num_front == n)
                {
                    Console.WriteLine(k + 1);
                    break;
                }
                tmp = num_back;
                num_back = num_front;
                num_front = tmp + num_front;
                k++;
            }

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
