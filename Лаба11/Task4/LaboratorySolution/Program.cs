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
            double p;
            double money = 1000, tmp = 1000, date = 0;

            p = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < tmp; i++)
            {
                tmp += (tmp/100)*p;
                if (tmp >= 1100)
                {
                    date = i+1;
                    break;
                }
            }

            Console.WriteLine(tmp);
            Console.WriteLine(date);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
