using System;
using System.IO;
using System.Threading.Tasks;
namespace HelloApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string writePath = @"C:\SomeDir\hta2.txt";
            string text = "Привет мир!\nПока мир...";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync(text);
                }
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync("Дозапись");
                    await sw.WriteAsync("4,5");
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey(true);
        }
    }
}