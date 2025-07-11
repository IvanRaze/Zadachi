using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static bool nechet(int a)
        {
            if (a % 2 == 0){
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nechet(b));
        }
    }
