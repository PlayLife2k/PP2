using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;//переменная b
            b = int.Parse(Console.ReadLine());//вводим вручную b в консоли , parse чтобы b приняло математическое значние
            int[] a = new int[b];// создаем массив и обзываем его буквой a , и даем ему размер переменной b которую мы вводим в консоли :D
            for (int i = 0; i <= b; i++)//
            {
                for (int t = 1; t <= i; t++)
                    Console.Write("[*]");
                Console.WriteLine();//используем WriteLine чтобы значение перешло вниз
            }
        }
    }
}
