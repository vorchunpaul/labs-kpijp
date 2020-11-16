using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MulticastDelegate
{
    class MathOperation
    {
        public static void MultiplyByTwo(double d)
        {
            double res = d * 2;
            Console.WriteLine("Multiply: " + res.ToString());
        }
        public static void Squre(double e)
        {
            double res = e * e;
            Console.WriteLine("Square" + res.ToString());
        }
    }
    class NewProgram
    {
        public delegate void del(double Qr);
        static void Main()
        {
            del d = MathOperation.MultiplyByTwo;
            d += MathOperation.Squre;
            Display(d, 2.00);
            Display(d, 9.9);
            Console.ReadLine();
        }
        static void Display(del action, double value)
        {
            Console.WriteLine("Result = " + value);
            action(value);
        }
    }
}