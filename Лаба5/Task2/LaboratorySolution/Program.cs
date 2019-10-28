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
            int a, b, ans; // создание переменных
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            while (a < b)
            {
                Console.WriteLine("Reenter A and B, A > B: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }

            ans = a / b;
            Console.WriteLine("Answer: " + ans);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
