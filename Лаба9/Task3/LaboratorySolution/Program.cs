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
            int n = 0;

            String[] arr1 = new String[9] {"одина", "двена", "трина", "четырна", "пятна", "шестна", "семна", "восемна", "девятна" };
            String[] arr2 = new String[4] {"десять", "двадцать", "тридцать", "сорок" };
            String[] arr3 = new String[9] {" одно"," два", " три", " четыре", " пять", " шесть", " семь", " восемь", " девять" };

            while (n < 10 || n > 40)
            {
                Console.WriteLine("Введите корректное число заданий в диапазоне [10, 40]!");
                n = int.Parse(Console.ReadLine());
            }

            if (n % 10 == 0)
            {
                Console.WriteLine(arr2[(n / 10)-1] + " учебных заданий");
            }
            else if (n < 20)
            {
                Console.WriteLine(arr1[(n % 10) - 1] + "дцать" + " учебных заданий");
            }
            else if (n > 20 && n%10 == 1)
            {
                Console.WriteLine(arr2[(n / 10) - 1] + arr3[(n%10) - 1] +" учебное задание");
            }
            else if (n > 20 && n%10 > 1 && n%10 < 5)
            {
                Console.WriteLine(arr2[(n / 10) - 1] + arr3[(n % 10) - 1] + " учебных задания");
            }
            else if (n > 20 && n % 10 > 4 && n % 10 < 10)
            {
                Console.WriteLine(arr2[(n / 10) - 1] + arr3[(n % 10) - 1] + " учебных заданий");
            }
            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
