using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaboratorySolution
{
    class Program
    {
        static public double Fact2(double N)
        {
            double sum = 1;
            if (N % 2 == 0)
            {
                for (int i = 2; i <= N; i += 2)
                {
                    sum *= i;
                }
                return sum;
            }
            else
            {
                for (int i = 1; i <= N; i += 2)
                {
                    sum *= i;
                }
                return sum;
            }
        }

        static void Main(string[] args)
        {
            int nin;

            Console.Write("N: ");
            nin = int.Parse(Console.ReadLine());

            Console.WriteLine("N!! = " + Fact2(nin));

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
