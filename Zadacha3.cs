using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static int Max(int a,int b,int c)
        {
            if (a>b & a > c){
                return a;
            }
            if (b > c){
                return b;
            }
            else
            {
                return c;
            }
        }
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Max(b,a,c));
        }
    }
}
