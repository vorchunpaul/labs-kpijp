using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0, z; try
            {
                z = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }

            Console.ReadKey(true);
        }
    }
}
