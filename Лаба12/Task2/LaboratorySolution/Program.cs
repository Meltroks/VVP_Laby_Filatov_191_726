using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaboratorySolution
{
    class Program
    {
        static public int Sign(int x)
        {
            if (x > 0) return 1;
            else if (x == 0) return 0;
            else return -1;
        }

        static void Main(string[] args)
        {
            int ain, bin;

            ain = int.Parse(Console.ReadLine());
            bin = int.Parse(Console.ReadLine());

            Console.WriteLine("Sign(A) + Sign(B) = " + (Sign(ain) + Sign(bin)));

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
