using System;
namespace Prim_Class0
{
    class Treug
    {
        double a, b, c;
        public void vvod()
        {
            Console.Write("a=");
            a = double.Parse(Console.ReadLine()); Console.Write("b=");
            b = double.Parse(Console.ReadLine()); Console.Write("c="); c = double.Parse(Console.ReadLine());
        }

        public double P1()
        {
            double s = 0; if (YesTreug())
            {
                double p = (a + b + c) / 2; s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                Console.WriteLine("Треугольник не существует."); s = -1;
            }
            return s;
        }

        bool YesTreug()
        {
            if (a + b > c && a + c > b && b + c > a) return true; else return false;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Тестирование класса Treug (треугольник)"); 
            Treug x = new Treug(); 
            x.vvod(); 
            double s = x.P1();
            Console.WriteLine("Площадь треугольника s={0}", s); 

            Console.ReadKey(true);
        }
    }
}