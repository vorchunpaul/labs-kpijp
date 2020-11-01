using System;
namespace Test_Indeksator1
{
    class Mas
    {
        private int n; private double[] x; public Mas()
        {
            n = 1; x = new double[n]; x[0] = 1;
        }
        public Mas(int n0)
        {
            n = n0; if (n < 1) n = 1; x = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = 1 + i;
            }
        }
        public double this[int i]
        {
            set
            {
                x[i] = value;
            }
            get
            {
                return x[i];
            }
        }
        public void print()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Тестирование работы индексаторов");
            Mas x = new Mas(3);

            // Использование индексатора для записи 
            x[0]=5; 

            // Использование индексатора для чтения 
            Console.WriteLine(x[1]); x.print(); 

            Console.ReadKey(true);
        }
    }
}
