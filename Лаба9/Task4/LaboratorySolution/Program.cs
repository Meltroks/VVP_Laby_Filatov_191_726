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
            int n;

            n = int.Parse(Console.ReadLine()); // ввод числа

            String[] arr1 = new String[10] {"", "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот " };
            String[] arr2 = new String[10] {"", "десять ", "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто " };
            String[] arr3 = new String[10] {"", "один ", "два ", "три ", "четыре ", "пять ", "шесть ", "семь ", "восемь ", "девять " };

            Console.WriteLine(arr1[(n/100)] + arr2[((n%100)/10)] + arr3[n%10]);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
