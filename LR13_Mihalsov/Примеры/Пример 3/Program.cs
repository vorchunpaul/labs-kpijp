using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MulticastDelegate1
{
    class Program
    {
        public delegate void showDelegate(string s);
        static void Main(string[] args)
        {
            showDelegate s = Display;
            s += Show;
            s("Hello");
            s("Scott");
            Console.Read();
        }
        public static void Display(string title)
        {
            Console.WriteLine(title);
        }
        public static void Show(string title)
        {
            Console.WriteLine(title);
        }
    }
}