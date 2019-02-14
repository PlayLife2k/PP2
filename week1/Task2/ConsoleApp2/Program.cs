using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student//создал класс Student
    {
        public string name;
        public string id;
        public int year_of_study;
        public void PrintInfo()
        {
            Console.Write(name + " " + id + " " + (year_of_study + 1));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();//Обзываем класс Student буквой s
            s.name = Convert.ToString(Console.ReadLine());//конвертируем из класса в строку и выводим в консоль
            s.id = Convert.ToString(Console.ReadLine());//конвертируем id из класса в строку и выводим в консоль
            s.year_of_study = Convert.ToInt32(Console.ReadLine());//конвертируем год+1 из класса в числовое значение и выводи в консоль
            s.PrintInfo();//Вывести информацию

        }
    }
}
