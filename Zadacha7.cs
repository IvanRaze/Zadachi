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
    class Account
    {
        public Account(int id1, int balance1) {
            id = id1;
            balance = balance1;
        }
        public int id;
        public int balance;

        public int deposite(int dep)
        {
            balance += dep;
            return balance;
        }
        public int Withdraw(int dep)
        {
            if (balance - dep < 0)
            {
                return balance;
            }
            else
            {
                balance -= dep;
                return balance;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account vasya = new Account(1,10);
            vasya.deposite(20);// balance будет на 20 больше
            Console.WriteLine(vasya.balance);//выведет 30
            vasya.Withdraw(20);//balance опять станет 10
            Console.WriteLine(vasya.balance);//выведет 10
        }
    }
}

