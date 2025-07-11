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
        public static int Factorial(int a)
        {
            int result = 1;
            for(int i = 1; i < a+1; i++)
            {
                result = result * i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(b));
        }
    }
}
