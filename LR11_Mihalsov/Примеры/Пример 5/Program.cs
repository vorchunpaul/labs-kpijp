using System;
namespace Prim_Interface5
{
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
    interface IBall
    {
        void play();
    }
    interface IGitara
    {
        void play();
    }
    interface IStudent : IBall, IGitara
    {
        void study(); new void play();
    }
    public class Worker : Man, IStudent
    {
        public Worker() : base()
        { }
        public Worker(string n) : base(n)
        { }
        void IBall.play()
        {
            Console.WriteLine(" - играет в мяч");
        }
        void IGitara.play()
        {
            Console.WriteLine(" - играет на гитаре");
        }
        public void study()
        {
            Console.WriteLine(" - учится в институте, а также");
        }
        void IStudent.play()
        {
            Console.WriteLine(" - играет в КВН");
        }
        public void work()
        {
            Console.WriteLine("\n - работает,");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Worker x = new Worker("Иван");
            x.print();
            x.work();
            x.study(); 
            ((IBall)x).play();
            ((IGitara)x).play();
            ((IStudent)x).play();
            Console.ReadKey(true);
        }
    }
}
