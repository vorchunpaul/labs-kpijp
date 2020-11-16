using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание
{
    class Program
    {
        delegate double IntExp(double x);
        static double Exp1(double x)
        {
            return 3*x - Math.Sin(2*x);
        }
        static double Exp2(double x)
        {
            return Math.Exp(-2 * x) - 2 * x + 1;
        }
        static double CalcIntegral(double a, double b, int n, IntExp exp)
        {
            double sum = 0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                sum += exp.Invoke(a + h * (i + 0.5));
            }
            return sum * h;
        }
        static void Main(string[] args)
        {
            double Integral1 = CalcIntegral(0, 2 * Math.PI, 100, Exp1);
            double Integral2 = CalcIntegral(0, Math.PI, 100, Exp2);

            Console.WriteLine("Значение первого интеграла {0}", Integral1);
            Console.WriteLine("Значение второго интеграла {0}", Integral2);
            Console.WriteLine("Разница интегралов {0}", Integral1 - Integral2);
            Console.ReadKey(true);
        }
    }
}
