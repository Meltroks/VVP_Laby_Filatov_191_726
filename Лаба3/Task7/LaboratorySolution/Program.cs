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
            double a, ans, ans2; // ������������� ����������
            a = double.Parse(Console.ReadLine()); // ���� ����������
            ans = a * a * a; // ��� ����������
            ans2 = ans * ans * ans * ans * ans;
            Console.WriteLine("A^15 = " + ans2); // �����
            

            Console.ReadLine(); // ����� ��� ��������� ����������
        }
    }
}
