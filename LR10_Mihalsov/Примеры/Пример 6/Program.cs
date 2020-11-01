using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ClassA
    {
        public int a;

        public ClassA(int i)
        {
            a = i;
        }
    }

    class ClassB : ClassA
    {
        public int b;

        public ClassB(int r, int i)
            : base(i)
        { b = r; }
    }

    class ClassC
    {
        public int a;

        public ClassC(int i)
        {
            a = i;
        }
    }

    class Program
    {
        static void Main()
        {
            ClassA objA1 = new ClassA(10);
            ClassA objA2 = new ClassA(5);

            // Присваивание однотипных объектов правильно:             
            objA2 = objA1; 

            ClassB objB = new ClassB(8, 9);
            // Присваивание объекта, имеющего тип унаследованного класса допускается: 
            objA1 = objB;             // Так нельзя 
                                      // objB = objA1; 

            // Присваивать похожие, но не связанные друг с другом 
            // принципом наследования объекты нельзя 
            ClassC objC = new ClassC(8);
            // objC = objA1; 

            Console.ReadLine();
        }
    }
}
