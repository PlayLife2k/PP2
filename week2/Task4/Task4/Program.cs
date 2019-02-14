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
            string FileName = "input.txt";
            var Fcre = File.Create(@"C:\Users\ww\source\repos\week2\Task4\"+FileName);
            Fcre.Close();
            Console.ReadKey();
            Directory.CreateDirectory(@"C:\Users\ww\source\repos\week2\Task4\FileName1");
            File.Copy(@"C:\Users\ww\source\repos\week2\Task4\" + FileName, @"C:\Users\ww\source\repos\week2\Task4\FileName1\" + FileName,true);
            File.Delete(@"C:\Users\ww\source\repos\week2\Task4\" + FileName);



           
        }
    }
}
