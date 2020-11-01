using System;
namespace Prim_String
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = "qwerty, t, r . abc f t";
            Console.WriteLine("Исходная строка:\n" + s);
            int k = s.IndexOf(".");
            Console.WriteLine("Первая точка находится в позиции: " + k);
            string s1 = s.Substring(0, k);
            Console.WriteLine(s1);
            int i;

            do
            {
                i = s1.IndexOf(',');
                if (i >= 0)
                    s1 = s1.Remove(i, 1);
            } while (i >= 0);

            Console.WriteLine(s1);
            string s2 = s.Substring(k);
            Console.WriteLine(s2);
            s2 = s2.Replace(' ', '*');
            Console.WriteLine(s2);
            s = s1 + s2;
            Console.WriteLine("Результирующая строка:\n" + s);

            Console.ReadKey(true);
        }
    }
}