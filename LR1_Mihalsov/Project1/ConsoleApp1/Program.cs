using System;

namespace _2_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, dx, x0, xn, a, b;
            double y;
            Console.WriteLine("Введите x0 = ");
            x0 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите xn = ");
            xn = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите dx = ");
            dx = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите a = ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b = ");
            b = float.Parse(Console.ReadLine());

            for (x = x0; x <= xn; x += dx)
            {
                y = Math.Sqrt((a + b * x) / (Math.Pow(Math.Log(x), 2)));
                Console.WriteLine("y = {1},\tx = {0}", x, y);
            }

            Console.ReadKey(true);
        }
    }
}
