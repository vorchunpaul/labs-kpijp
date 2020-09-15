using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            double y;

            Console.Write("Введиете X = ");
            x = float.Parse(Console.ReadLine());

            if (x <= 0)
            {
                y = Math.Exp(2.0 * x);
                Console.WriteLine("Выбрано условие: x <= 0");
            }
            else
            {
                if (0.0 < x && x < 7.0)
                {
                    y = Math.Sqrt(Math.Abs(Math.Pow(x, 2) - 2));
                    Console.WriteLine("Выбрано условие: 0 < x < 7");
                }
                else
                {
                    y = x / 2.0 - Math.Pow(x, 2);
                    Console.WriteLine("Выбрано условие: Во всех остальных случаях");
                }
            }
            Console.WriteLine("y = {0}", y);
        }
    }
}
