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
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 3, 17, 8, 25, 9, 11, 4, 15 };//мне в падлу было делать чтобы пользователь вводил потому как и так и так нормально
            var result = numbers
                .Where(n => n > 10)//все функции LINQ
                .OrderByDescending(n => n)//это если чо сортировка название странное
                .ToArray();//я решил что в массив круто будет
            Console.WriteLine("Числа больше 10: ");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
