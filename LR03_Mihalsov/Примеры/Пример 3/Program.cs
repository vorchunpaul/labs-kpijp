using System;
namespace Prim_IF_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double a, b, c, p, s;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            c = double.Parse(Console.ReadLine());
            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Треугольник существует");
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("s={0}", s);
            }
            else
                Console.WriteLine("Треугольник не существует");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
