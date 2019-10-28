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
            int n, ans; // создание переменных
            n = int.Parse(Console.ReadLine()); // ввод значений переменных

            ans = n / 1024;

            Console.WriteLine("Kilobytes: " + ans);


            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
