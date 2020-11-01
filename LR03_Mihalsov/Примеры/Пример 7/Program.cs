using System;
namespace Prim_for
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
            for (i = 1, s = 0; i <= n; i++)
                s += i * i;
            Console.WriteLine("s={0}", s);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
