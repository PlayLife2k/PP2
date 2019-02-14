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
        public static bool Prime(int a)
        {
            if (a == 0 || a == 1) return false;
            for (int i= 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\ww\source\repos\week2\Task2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] s = sr.ReadLine().Split();
            sr.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"C:\Users\ww\source\repos\week2\Task2\output.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sr1 = new StreamWriter(fs1);
            for(int i = 0; i < s.Length; i++)
            {
                if (Prime(int.Parse(s[i]))==true) sr1.Write(s[i] + " ");
            }
            sr1.Close();








        }
    }
}
