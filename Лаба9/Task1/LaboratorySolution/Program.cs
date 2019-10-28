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
            int day = 0, month = 0;

            while(day < 1 || day > 31)
            {
                Console.WriteLine("Please input day number in [1, 31] range!");
                day = int.Parse(Console.ReadLine());
            }

            while (month < 1 || month > 12)
            {
                Console.WriteLine("Please input month number in [1, 12] range!");
                month = int.Parse(Console.ReadLine());
            }

            String[] arr = new String[12] { " January", " February", " March", " April", " May", " June", " July", " August", " September", " October", " November", " December"};

            Console.WriteLine(day + arr[month - 1]);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
