using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static bool Prime(int a)//создаем правила для Prime numbers
        {
            if (a == 0 || a == 1) return false;// если значение a=0 или a=1 то автоматически выдает false(не прайм)
            for (int i= 2; i <= Math.Sqrt(a); i++)// правила для отбора prime чисел
            {
                if (a % i == 0) return false;// если a делиться на i с остатком 0 то не является Prime числом
            }
            return true;// остальные значения true и являются Prime числами---->Prime(Простые)

        }
        static void Main(string[] args)//void Main--->главное правило
        {
            FileStream fs = new FileStream(@"C:\Users\ww\source\repos\week2\Task2\input.txt", FileMode.Open, FileAccess.Read);//открываем и читаем файл по данному пути
            StreamReader sr = new StreamReader(fs);//переводим иероглифы в понятный для нас язык 
            string[] s = sr.ReadLine().Split();//Выполняет чтение строки символов из текущего потока и возвращает в виде строки , split для разделения 
            sr.Close();//обязательно закрываем sr
            fs.Close();//обязательно закрываем fs
            FileStream fs1 = new FileStream(@"C:\Users\ww\source\repos\week2\Task2\output.txt", FileMode.Open, FileAccess.Write);//открываем файл но уже редактируем(НЕ ЧИТАЕМ !)
            StreamWriter sr1 = new StreamWriter(fs1);//переводи в понятный для нас язык
            for(int i = 0; i < s.Length; i++)//задаем размер массива
            {
                if (Prime(int.Parse(s[i]))==true) sr1.Write(s[i] + " ");// тут мы используем условие которые мы писали в начале , int.Parse---->преобразуе строку s в математический массик с размером ш---->s[i], если выполняется условие простых чисел то эти числа переносятся в новый файл output с пробелом
            }
            sr1.Close();//закрываем StreamReader1
        }
    }
}
