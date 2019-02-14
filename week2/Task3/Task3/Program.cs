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
        public static void Level(int level)
        {
            for (int i=0; i<level; i++)
            {
                Console.Write("  ");
            }
        }
        public static void tree(DirectoryInfo dir,int level)
        {
            foreach(FileInfo fi in dir.GetFiles())
            {
                Level(level);
                Console.WriteLine(fi.Name);
            }
            foreach(DirectoryInfo dir1 in dir.GetDirectories())
            {
                Level(level);
                Console.WriteLine(dir1.Name);
                tree(dir1, level + 2);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ww\source\repos");
            tree(dir, 0);

        }
    }
}
