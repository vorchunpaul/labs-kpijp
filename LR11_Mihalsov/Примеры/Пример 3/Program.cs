using System;
namespace Prim_Interface3
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
    public class Student : Man, IBall, IGitara
    {
        public Student() : base()
        { }
        public Student(string n) : base(n)
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
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Наследование от класса и двух интерфейсом, имеющих метод с одинаковым именем 
            Student x = new Student("Иван"); x.print();
            x.study(); ((IBall)x).play();
            ((IGitara)x).play();
            Console.WriteLine();
            Student y = new Student("Пётр"); y.print();
            y.study();
            IBall i1 = y; 
            i1.play();
            IGitara i2 = y; 
            i2.play();

            Console.ReadKey(true);
        }
    }
}
