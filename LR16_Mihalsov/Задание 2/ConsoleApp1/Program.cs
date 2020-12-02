using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib4lab;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            float x;
            do Console.Write("Введите x = ");
            while (!float.TryParse(Console.ReadLine(), out x));

            uint n;
            do Console.Write("Введите номер функции = ");
            while (!uint.TryParse(Console.ReadLine(), out n) || n > 3);

            double y = 0;
            try
            {
                switch (n)
                {
                    case 1:
                        y = FunctionClass.f1(x);
                        break;
                    case 2:
                        y = FunctionClass.f2(x);
                        break;
                    case 3:
                        y = FunctionClass.f3(x);
                        break;
                }
                Console.WriteLine("Результат {0}", y);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка в вичислении");
            }
            goto begin;
        }
    }
}
