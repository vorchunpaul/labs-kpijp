using System;
namespace Prim_Metod3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 3, b = 4;
            Console.WriteLine("До входа в метод:\n a={0} b={1}", a, b);
            Obmen(ref a, ref b);
            Console.WriteLine("После выхода из метода:\n a={0} b={1}", a, b);

            Console.ReadKey(true);
        }
        public static void Obmen(ref int a, ref int b)
        {
            Console.WriteLine("В методе до обмена:\n a={0} b={1}", a, b); int c; c = a; a = b; b = c;
            Console.WriteLine("В методе после обмена:\n a={0} b={1}", a, b);
        }
    }
}
