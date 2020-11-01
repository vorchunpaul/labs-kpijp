using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void SpeedWay(float t, float a, float v0, out double v, out double S)
        {
            v = v0 + (a * t);
            S = Math.Pow(v0, 2) + (a * Math.Pow(t, 2) / 2);
        }

        static void Main(string[] args)
        {
            // v - конечная скорость
            // S - пройденный путь
            double v, S;

            // Ввод значений с клавиатуры
            Console.Write("Введите время пути (t): "); float t = float.Parse(Console.ReadLine());
            Console.Write("Введите ускорение (a): "); float a = float.Parse(Console.ReadLine());
            Console.Write("Введите начальную скорость (v0): "); float v0 = float.Parse(Console.ReadLine());

            // Вызов функции расчёта
            SpeedWay(t, a, v0, out v, out S);

            // Вывод значений
            Console.WriteLine("Конечная скорость (v): {0}", v);
            Console.WriteLine("Пройденное растояние (S): {0}", S);

            Console.ReadKey(true);
        }
    }
}
