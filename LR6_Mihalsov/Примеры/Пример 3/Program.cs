using System;
namespace ConsoleApplicationi
{
    class Classl
    {
        static void Main()
        {
            int[] a = { 24, 50, 18, 3, 16, -7, 9, -1 };
            PrintArray("Исходный массив:", a);
            Console.WriteLine("Поизиция числа 18 = {0}" , Array.IndexOf(a, 18) + 1);
            Array.Sort(a);
            PrintArray("\nУпорядоченный массив:", a);
            Console.WriteLine("Поизиция числа 18 = {0}", Array.BinarySearch(a, 18) + 1);

            Console.ReadKey(true);
        }

        public static void PrintArray(string header, int[] a)
        {
            Console.WriteLine(header); 
            for (int i = 0; i < a.Length; ++i)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
