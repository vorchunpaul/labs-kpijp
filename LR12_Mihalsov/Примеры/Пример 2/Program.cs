using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число"); 
            int x;
            string input = Console.ReadLine(); 
            
            if (int.TryParse(input, out x))
            {
                x *= x;
                Console.WriteLine("Квадрат числа: " + x);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.ReadKey(true);
        }
    }
}
