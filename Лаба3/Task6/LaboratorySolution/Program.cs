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
            double a, ans; // инициализация переменных
            a = double.Parse(Console.ReadLine()); // ввод переменных
            ans = a * a; // доп переменная
            Console.WriteLine("A^8 = " + (ans * ans * ans * ans)); // вывод
            

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
