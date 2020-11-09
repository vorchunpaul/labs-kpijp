using System;
namespace Prim_Interface2
{
    interface IPlayer
    {
        void play();
    }
    public class Man
    {
        string name; public Man()
        {
            name = "NoName";
        }
        public Man(string n)
        {
            name = n;
        }
        public void print()
        {
            Console.Write(name);
        }
    }
    public class Ball : Man, IPlayer
    {
        public Ball() : base()
        { }
        public Ball(string n) : base(n)
        { }
        public void play()
        {
            Console.WriteLine(" - играет в мяч");
        }
    }
    public class Gitara : Man, IPlayer
    {
        public Gitara() : base()
        { }
        public Gitara(string n) : base(n)
        { }
        public void play()
        {
            Console.WriteLine("- играет на гитаре");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //Наследование от одного класса и одного интерфейса для двух классов 
            Ball x = new Ball("Иван"); 
            x.print(); 
            x.play();
            Gitara y = new Gitara("Андрей"); 
            y.print();
            y.play();
            Console.ReadKey(true);
        }
    }
}
