using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите строку: "); 
                string message = Console.ReadLine(); 
                if (message.Length > 8)
                {
                    throw new Exception("Длина строки больше 8 символов");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            Console.ReadKey(true);

        }
    }
}
