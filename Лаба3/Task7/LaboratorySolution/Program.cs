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
            double a, ans, ans2; // инициализация переменных
            a = double.Parse(Console.ReadLine()); // ввод переменных
            ans = a * a * a; // доп переменные
            ans2 = ans * ans * ans * ans * ans;
            Console.WriteLine("A^15 = " + ans2); // вывод
            

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
