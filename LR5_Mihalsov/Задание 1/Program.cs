using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class SpeedWay
    {
        float _t;
        float _a;
        float _v0;

        public double EndSpeed
        {
            get
            {
                return _v0 + (_a * _t);
            }
        }

        public double Distance
        {
            get
            {
                return Math.Pow(_v0, 2) + (_a * Math.Pow(_t, 2) / 2);
            }
        }
        public SpeedWay(float t, float a, float v0)
        {
            _t = t;
            _a = a;
            _v0 = v0;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите время пути (t): "); float t = float.Parse(Console.ReadLine());
            Console.Write("Введите ускорение (a): "); float a = float.Parse(Console.ReadLine());
            Console.Write("Введите начальную скорость (v0): "); float v0 = float.Parse(Console.ReadLine());

            SpeedWay A = new SpeedWay(t,a,v0);

            Console.WriteLine("Конечная скорость (v): {0}", A.EndSpeed);
            Console.WriteLine("Пройденное растояние (S): {0}", A.Distance);

            Console.ReadKey(true);

        }
    }
}
