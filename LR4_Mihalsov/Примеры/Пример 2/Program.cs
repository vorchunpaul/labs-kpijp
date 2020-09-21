using System;
namespace Prim_Metod2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double a = 3, b = 4, c = 5;
            Console.WriteLine("Длины сторон:\n a={0} b={1} c={2}", a, b, c); if (Treug(a, b, c))
                Console.WriteLine("Да, треугольник существует");
            else
                Console.WriteLine("Нет, треугольник не существует");

            Console.ReadKey(true);
        }
        public static bool Treug(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a) return true; else return false;
        }
    }
}
