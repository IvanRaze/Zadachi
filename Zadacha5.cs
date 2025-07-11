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
        public static bool palendrom(string a)
        {
            for (int i = 0;i < a.Length; i++)
            {
                if (a[i] == a[a.Length-1-i])
                {
                    continue;
                }
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            Console.WriteLine(palendrom(b));
        }
    }
}
