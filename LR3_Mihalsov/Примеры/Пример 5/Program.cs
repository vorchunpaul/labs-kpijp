using System;
namespace Prim_while
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, n, s;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            s = 0;
            i = 1;
            while (i <= n)
            {
                s += i * i;
                i++;
            }
            Console.WriteLine("s={0}", s);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
