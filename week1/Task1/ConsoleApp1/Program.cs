using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static bool Prime(int element)//метод для поиска простых чисел
        {
            if (element == 0 || element == 1) return false;
            for(int i =2 ;i <= Math.Sqrt(element); ++i)
            {
                if (element % i == 0) return false;
            }
            return true;//возвращает тру если число простое
        }

        static void Main(string[] args)
        {
            int arsz = Convert.ToInt32(Console.ReadLine());//объявляем размер массива
            string[] arr = Console.ReadLine().Split();//Элементы массива
            int cnt = 0;//счетчик простых чисел
            for (int i = 0; i < arsz; i++)
            {
                if (Prime(int.Parse(arr[i]))) cnt++;
            }
            Console.WriteLine(cnt);//выводим колво простых чисел
            for (int i = 0; i < arsz; i++)
            {
                if (Prime(int.Parse(arr[i]))) Console.Write(arr[i] + " ");//выводим простые числа
            }
        }
    }
}