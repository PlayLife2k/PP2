using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void Level(int level)//правило для пробелов в консоли
        {
            for (int i=0; i<level; i++)
            {
                Console.Write("  ");
            }
        }
        public static void tree(DirectoryInfo dir,int level)//Данный класс предоставляет функциональность для создания, удаления, перемещения и других операций с каталогами. 
        {
            foreach(FileInfo fi in dir.GetFiles())//FIleInfo дает доступ к открытию и редактированию файлов , dir.GeFiles возвращает список файлов с оцтуплением(Level)
            {
                Level(level);
                Console.WriteLine(fi.Name);//Возвращаем имя файла
            }
            foreach(DirectoryInfo dir1 in dir.GetDirectories())//если в папки есть папки то он вовращает папки с оцтупами(Level) и именами подпапок , level + 2 означает двойной оцтуп дабы не было каши в консоли
            {
                Level(level);
                Console.WriteLine(dir1.Name);
                tree(dir1, level + 2);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ww\source\repos");//открываем путь к папкам для выполнения операций выше
            tree(dir, 0);// я так написал чтобы папки начинались с начала консоли

        }
    }
}
