using System;
using System.IO;
using System.Threading.Tasks;

namespace Пример_4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = @"C:\SomeDir\hta.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            // асинхронное чтение
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey(true);
        }
    }
}
