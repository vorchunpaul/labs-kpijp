using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static double f1(float x)
        {
            return Math.Pow(Math.Sin(x),4);
        }
        static double f2(float x)
        {
            return Math.Pow(x, 3 - 0.2 * x);
        }
        static double f3(float x)
        {
            return Math.Pow(x,2) - 6 * x + 18;
        }

        static void Main(string[] args)
        {
            // y - переменная для сохранеия подсчитанного значения
            double y = 0;
            // n - переменная для сохранеия выбранной пользователем функции
            int n;

            // Ввходим x
            Console.Write("Введите x : "); float x = float.Parse(Console.ReadLine());

            // Пока пользователь не введет значения в нужном диапозоне (0-3), начинать цикл заново
            do
            {
                Console.Write("Введите номер функции для расчета (1 <= n <= 3) : ");
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 && n <= 3));

            // В соотведствии с выбранной функцией производим расчёт
            switch (n)
            {
                case 1:
                    y = f1(x);
                    break;
                case 2:
                    y = f2(x);
                    break;
                case 3:
                    y = f3(x);
                    break;
            }

            // Вывод полученного значения
            Console.WriteLine("y : {0}", y);
            Console.ReadKey(true);
        }
    }
}
