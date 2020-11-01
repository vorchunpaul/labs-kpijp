using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class functionChose
    {
        int _chose;
        float _x;

        double f1(float x)
        {
            return Math.Pow(Math.Sin(x), 4);
        }
        double f2(float x)
        {
            return Math.Pow(x, 3 - 0.2 * x);
        }
        double f3(float x)
        {
            return Math.Pow(x, 2) - 6 * x + 18;
        }

        public functionChose(int chose, float x)
        {
            _chose = chose;
            _x = x;
        }

        public double Y
        {
            get
            {
                switch (_chose)
                {
                    case 1:
                        return f1(_x);
                        break;
                    case 2:
                        return f2(_x);
                        break;
                    case 3:
                        return f3(_x);
                        break;
                    default:
                        return -1.0;
                }
            }
        }
    }
    class Program
    {
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

            functionChose F = new functionChose(n,x);

            Console.WriteLine("y : {0}", F.Y);

            Console.ReadKey(true);
        }
    }
}
