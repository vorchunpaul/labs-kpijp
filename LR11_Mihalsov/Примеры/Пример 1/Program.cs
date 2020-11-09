using System;
namespace Prim_Interface1
{
    interface IPlayer
    {
        void play();
    }
    public class Ball : IPlayer
    {
        public void play()
        {
            Console.WriteLine("Игра в мяч");
        }
    }
    public class Gitara : IPlayer
    {
        public void play()
        {
            Console.WriteLine("Игра на гитаре");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Тест одного интерфейса для двух классов"); Ball x = new Ball(); x.play();
            Gitara y = new Gitara(); 
            y.play();
            Console.ReadKey(true);
        }
    }
}
