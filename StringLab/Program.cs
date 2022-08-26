using System;
using System.Collections.Generic;
using System.Linq;


namespace StringLab
{
    delegate void myString(string myStr);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str1 = Console.ReadLine();
            myString print = Class.Print;
            print += Class.StrR;
            print += Class.Sym;
            print(str1);

        }
    }
}