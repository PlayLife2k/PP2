using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();// вводим строку s
            File.WriteAllText(@"C:\Users\ww\source\repos\week2\Task1\input.txt", s); //создет файл и вписывает строку s
            FileStream fs = new FileStream(@"C:\Users\ww\source\repos\week2\Task1\input.txt", FileMode.OpenOrCreate, FileAccess.Read);//Класс FileStream представляет возможности по считыванию из файла и записи в файл. Тут мы открываем файл в режими чтения
            StreamReader sr = new StreamReader(fs);//переводи FileStream на понятный нам язык
            string str = sr.ReadLine();//Выполняет чтение строки символов из текущего потока и возвращает в виде строки
            sr.Close();//закрываем StreamReader
            fs.Close();//закрываем FileStream
            int cnt=0;//создаем счетчик
            for (int i = 0,j = str.Length-1; i < str.Length && j>=0; i++, j--)//создаем цикл для проверки полиндромов
            {
                if (str[i] == str[j]) cnt++;
            }
            if (str.Length == cnt) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            

        }
    }
}
