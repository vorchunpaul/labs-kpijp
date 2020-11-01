using System;
namespace Test_Indeksator2
{
    class Matr
    {
        private int n; private int m; private double[,] x; public Matr()
        {
            n = m = 1; x = new double[n, m]; x[0, 0] = 1;
        }
        public Matr(int n0, int m0)
        {
            n = n0; if (n < 1) n = 1;
            m = m0;
            if (m < 1) m = 1; x = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    x[i, j] = (i + 1) * 10 + j + 1;
                }
            }
        }
        public double this[int i, int j]
        {
            set
            {
                x[i, j] = value;
            }
            get
            {
                return x[i, j];
            }
        }
        public void print()
        {
            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(x[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Тестирование работы индексаторов");
            Matr x = new Matr(3, 3);
            // использование индексатора для записи
            x[0,0]=5; 
            // использование индексатора для чтения 
            Console.WriteLine(x[1,1]); 
            x.print(); 
            Console.ReadKey(true);
        }
    }
}
