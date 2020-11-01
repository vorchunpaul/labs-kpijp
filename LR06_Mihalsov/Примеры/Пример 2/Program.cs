using System;
namespace Prim_Matr1
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int n = 2; 
            const int m = 3; 
            double[,] a = new double[n, m];
            int i, j; 

            Console.WriteLine("Задайте матрицу A[{0}*{1}]:", n, m); 
            for (i = 0; i < n; i++) 
                for (j = 0; j < m; j++) 
                    a[i, j] = double.Parse(Console.ReadLine()); 
            
            double max = Math.Abs(a[0, 0]); 
            
            for (i = 0; i < n; i++) 
                for (j = 0; j < m; j++) 
                    if (Math.Abs(a[i, j]) > max) 
                        max = Math.Abs(a[i, j]); 
            
            Console.WriteLine("max = {0}", max); 
            
            for (i = 0; i < n; i++) 
                for (j = 0; j < m; j++) 
                    a[i, j] /= max; 
            
            Console.WriteLine("Mатрица A[{0}*{1}] после нормирования:", n, m); 
            
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t "); Console.WriteLine();
            }
            
            Console.ReadKey(true);
        }
    }
}