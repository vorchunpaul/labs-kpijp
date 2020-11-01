using System;
namespace Prim_do
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, n, s;
            do
            {
                Console.WriteLine("Задайте n>0:");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1);
            s = 0;
            i = 1;
            do
            {
                s += i * i;
                i++;
            }
            while (i <= n);
            Console.WriteLine("s={0}", s);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
