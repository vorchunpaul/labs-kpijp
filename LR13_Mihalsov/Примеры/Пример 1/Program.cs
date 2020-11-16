using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DelgateForNotes
{
    class Program
    {
        // Объявление делегата, ссылающегося на функцию     // с двумя параметрами и целочисленным результатом     
        public delegate int AddDelegate(int num1, int num2);

        static void Main(string[] args)
        {
            // Создание метода делегата и передача функции Add в качестве аргумента 
            AddDelegate funct1 = new AddDelegate(Add);
            // Вызов делегата       
            int k = funct1(7, 2);
            Console.WriteLine("Sumation = {0}", k);
            Console.Read();
        }

        // Статическая функция Add с той же сигнатурой, что и у делегата     
        public static int Add(int num1, int num2)
        {
            Console.WriteLine("I am called by Delegate");
            int sumation; sumation = num1 + num2; return sumation;
        }
    }
}
