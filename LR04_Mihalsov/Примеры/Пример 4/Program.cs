using System;
namespace Prim_Metod4
{
    class Program
    {
        public static void Main(string[] args)
        {
            double a, b, c, ar, geo, kv; Console.Write("a=");
            a = double.Parse(Console.ReadLine()); Console.Write("b="); b = double.Parse(Console.ReadLine()); Console.Write("c=");
            c = double.Parse(Console.ReadLine());
            Srednee(a, b, c, out ar, out geo, out kv);
            Console.WriteLine("Среднее арифметическое = {0}", ar);
            Console.WriteLine("Среднее геометрическое = {0}", geo);
            Console.WriteLine("Среднее квадратическое = {0}", kv);

            Console.ReadKey(true);
        }
        public static void Srednee(double a, double b, double c, out double ar, out double geo, out double kv)
        {
            ar = (a + b + c) / 3; geo = Math.Pow(a * b * c, 1.0 / 3); kv = Math.Sqrt(a * a + b * b + c * c);
        }
    }
}
