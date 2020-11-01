using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyClass
    {
        public int x, y, z;

        // Конструктор базового класса         
        public MyClass(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    class ClassA : MyClass
    {
        int point;

        // Конструктор производного класса 
        public ClassA(int point, int x, int y, int z)
            : base(x, y, z)
        {
            this.point = point;
        }

        public void Pointer(ClassA obj)
        {
            obj.x *= obj.point;
            obj.y *= obj.point;
            obj.z *= obj.point;
            Console.WriteLine("Новые координаты объекта: {0} {1} {2}", obj.x, obj.y, obj.z);
        }
    }


    class Program
    {
        static void Main()
        {
            ClassA obj = new ClassA(10, 1, 4, 3);
            Console.WriteLine("Координаты объекта: {0} {1} {2}", obj.x, obj.y, obj.z); obj.Pointer(obj);

            Console.ReadLine();
        }
    }
}
