using System;
using System.IO;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string writePath = @"C:\SomeDir\hta.txt";
            string text = "Привет мир!\nПока мир...";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Дозапись");
                    sw.Write(4.5);
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