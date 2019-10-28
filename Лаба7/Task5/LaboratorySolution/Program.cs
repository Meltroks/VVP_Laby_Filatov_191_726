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
            int a; // создание переменных

            a = int.Parse(Console.ReadLine());
            int[] arr = new int[4];

            for (int i = 0; i<4; i++)
            {
                arr[i] = a % 10;
                a /= 10;
            }

            if (arr[0] == arr[3] && arr[1] == arr[2]) Console.WriteLine("TRUE");
            else Console.WriteLine("FALSE");

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
