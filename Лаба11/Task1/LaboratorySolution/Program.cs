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
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            for(int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++) Console.Write(i + " ");
                Console.WriteLine();
            }

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
