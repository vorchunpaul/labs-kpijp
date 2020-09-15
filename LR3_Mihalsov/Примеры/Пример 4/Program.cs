using System;
namespace Prim_switch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Задайте номер недели:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Неверный номер для дня недели: {0}", n);
            break;
            }
            Console.Write("Press any key to continue . . .");
            Console.ReadKey(true);
        }
    }
}
