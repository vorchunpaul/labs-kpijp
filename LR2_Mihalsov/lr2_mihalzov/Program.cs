using System;

namespace lr2_mihalzov
{
    class Program
    {
        
        static void Main(string[] args)
        {
            float x, y, z;
            double b;
            Console.WriteLine("Введиете x:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Введиете y:");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("Введиете z:");
            z = float.Parse(Console.ReadLine());

            b = 1.0 + (Math.Pow(x, 2) + 1.0) / (3.0  + Math.Pow(y, 2)) + Math.Pow(Math.Sin(2.0 * z), 2);

            Console.WriteLine("b = {0}", b);
        }
    }
}
