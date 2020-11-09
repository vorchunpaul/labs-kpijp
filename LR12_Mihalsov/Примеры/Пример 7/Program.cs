using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
                catch
                {
                    Console.WriteLine("Возникло исключение"); throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey(true);
        }
    }
}
