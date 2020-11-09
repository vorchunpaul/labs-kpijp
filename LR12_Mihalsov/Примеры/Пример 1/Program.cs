using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5; int y = 0; int z = x / y;
                Console.WriteLine($"Результат: {z}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }

            Console.WriteLine("Конец программы");
            Console.ReadKey(true);
        }
    }
}
