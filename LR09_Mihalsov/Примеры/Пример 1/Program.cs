using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример1
{
    enum Directions { Left, Right, Forward, Back };
    // объявление перечисления
    class Program
    {
        public static void GoTo(Directions direction)
        {
            switch (direction)
            {
                case Directions.Back:
                    Console.Write("Go back");
                    break;
                case Directions.Forward:
                    Console.Write("Go forward");
                    break;
                case Directions.Left:
                    Console.Write("Turn left");
                    break;
                case Directions.Right:
                    Console.Write("Turn right ");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Directions direction = Directions.Forward;
            GoTo(direction); // "Go forward"
            Console.WriteLine(" - " +(int)Directions.Forward);
            Console.ReadKey();
        }
    }

}
