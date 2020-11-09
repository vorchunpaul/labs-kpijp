using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5; int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}"); 
            }

            Console.ReadKey(true);

        }
    }
}
