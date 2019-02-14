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
            string s = Console.ReadLine();
            File.WriteAllText(@"C:\Users\ww\source\repos\week2\Task1\input.txt", s);
            FileStream fs = new FileStream(@"C:\Users\ww\source\repos\week2\Task1\input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            sr.Close();
            fs.Close();
            int cnt=0;
            for (int i = 0,j = str.Length-1; i < str.Length && j>=0; i++, j--)
            {
                if (str[i] == str[j]) cnt++;
            }
            if (str.Length == cnt) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            

        }
    }
}
