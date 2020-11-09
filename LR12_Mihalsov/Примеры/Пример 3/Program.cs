
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;

            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException) when (y == 0 && x == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey(true);
        }
    }
}
