using System;
using System.Text;
using System.IO;
using System.Threading.Tasks;
namespace HelloApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = @"C:\SomeDir\hta.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
                // асинхронное чтение
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    Console.WriteLine(await sr.ReadToEndAsync());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey(true);
        }
    }
}