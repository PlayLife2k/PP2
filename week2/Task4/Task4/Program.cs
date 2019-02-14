using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "input.txt";//cоздаем файл который мы хотим перенести в другую папку и удалить оригинал
            var Fcre = File.Create(@"C:\Users\ww\source\repos\week2\Task4\" + FileName);// команда для создания файла в указанной директории
            Fcre.Close();//обязательно закрываем дабы команда работала
            Console.ReadKey();//после выполнения условий и нажатей любой клавиши пройзодет действия описанные ниже
            Directory.CreateDirectory(@"C:\Users\ww\source\repos\week2\Task4\FileName1");//команда для создании папки
            File.Copy(@"C:\Users\ww\source\repos\week2\Task4\" + FileName, @"C:\Users\ww\source\repos\week2\Task4\FileName1\" + FileName , true);// копируем наш файл из одной папки в новую папку , обязательно незабываем написать true так как по дефолту стоит значение false , если мы не напишем true то нам не удасться скопировать файл в новую папку 
            File.Delete(@"C:\Users\ww\source\repos\week2\Task4\" + FileName);// удаляем оригинал из изначальной папки так как мы скопировали ее во вторую

        }
    }
}
