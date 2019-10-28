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
           char dir = 'C'; int n; 
           Console.WriteLine("Направление: " + dir);

           n = int.Parse(Console.ReadLine()); // ввод переменной для поворота

           if (n == 0) dir = dir; // алгоритм не поворота
           else if(n == 1) // алгоритм поворота влево
            {
                if (dir == 'C') dir = 'З';
                else if (dir == 'З') dir = 'Ю';
                else if (dir == 'Ю') dir = 'В';
                else if (dir == 'В') dir = 'С';

                Console.WriteLine("Направление: " + dir);
            }
           else if (n == -1) // алгоритм поворота вправо
            {
                if (dir == 'C') dir = 'В';
                else if (dir == 'В') dir = 'Ю';
                else if (dir == 'Ю') dir = 'З';
                else if (dir == 'З') dir = 'С';
                Console.WriteLine("Направление: " + dir);
            }

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
