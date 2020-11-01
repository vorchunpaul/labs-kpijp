using System;
namespace Prim_Mas1
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] x = new double[5]; 
            int i, n = x.Length; 
            Console.WriteLine("Задайте {0} вещественных чисел:", n);
            
            for (i = 0; i < n; i++) { 
                Console.Write("x[{0}] = ", i);
                x[i] = double.Parse(Console.ReadLine()); 
            }
            double s = 0; 

            for (i = 0; i < n; i++) 
                s += x[i]; 
            
            s /= n;

            for (i = 0; i < n; i++) 
                x[i] -= s; 

            Console.WriteLine("Массив после обработки:");

            foreach (double r in x) 
                Console.WriteLine(r); 

            Console.ReadKey(true);
        }
    }
}
