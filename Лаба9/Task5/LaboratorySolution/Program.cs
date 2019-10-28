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

            String[] arr1 = new String[5] {"зелен", "красн", "желт", "бел", "черн" };
            String[] arr2 = new String[12] { "ой крысы", "ой коровы", "ого тигра", "ого зайца", "ого дракона", "ой змеи", "ой лошади", "ой овцы", "ой обезьяны", "ой курицы", "ой собаки", "ой свиньи" };

            Console.Write("год ");
            if ((n % 60) < 12) Console.Write(arr1[0]);
            else if((n % 60) > 12 && (n % 60) <= 24) Console.Write(arr1[1]);
            else if ((n % 60) > 24 && (n % 60) <= 36) Console.Write(arr1[2]);
            else if ((n % 60) > 36 && (n % 60) <= 48) Console.Write(arr1[3]);
            else if ((n % 60) > 48 && (n % 60) <= 60) Console.Write(arr1[4]);

            Console.WriteLine(arr2[(n % 60)%12 - 4]);

            Console.ReadLine(); // пауза для просмотра результата
        }
    }
}
