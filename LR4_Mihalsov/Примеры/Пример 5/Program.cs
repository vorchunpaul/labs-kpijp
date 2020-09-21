using System;
namespace Prim_Metod5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int s; s = fSum(4, 3, 12);
            Console.WriteLine("Сумма = " + s);

            Console.ReadKey(true);
        }
        public static int fSum(params int[] x)
        {
            int s = 0; for (int i = 0; i < x.Length; i++) s += x[i]; return s;
        }
    }
}
