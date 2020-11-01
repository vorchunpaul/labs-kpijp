using System;
namespace Prim_Svojstvo
{
    public class Okr
    {
        int x, y, r; // координаты центра окружности и её радиус 
        public Okr() 
        { 
            x = y = 100; 
            r = 10; 
        }

        public Okr(int x0, int y0, int r0)
        {
            x = x0; 
            y = y0;
            r = r0;
        }
        public void print()
        {
            Console.WriteLine("x = {0} y = {1} r = {2}", x, y, r);
        }

        public int Radius
        {
            set
            {
                if (value > 0) r = value;
                else
                {
                    Console.WriteLine("Недопустимое значение для поля: {0}", value);
                    Console.WriteLine("Поле сохраняет прежнее значение: {0}", r);
                }
            }
            get
            {
                return r;
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Okr x = new Okr(25, 45, 5); x.print();
                x.Radius = 4;
                x.print();
                int r2 = x.Radius * 2;
                Console.WriteLine("Удвоенное значение радиуса r2 = {0}", r2);
                
                Console.ReadKey(true);
            }
        }

    }
}