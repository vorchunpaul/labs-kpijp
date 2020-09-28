using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder hello = new StringBuilder("Привет, меня зовут Александр Ерохин",120);
           
            hello.AppendFormat("Я рад вас приветствовать на моем сайте professorweb.ru");
            // Зашифруем строку, хранящуюся в переменной hello
            Console.WriteLine("Исходная строка: \n {0}\n", hello);
            for (int i = 'я'; i >= 'a'; i--)
                hello = hello.Replace((char)i, (char)(i + 3));

            Console.WriteLine("Зашифрованная строка:\n {0}", hello);

            Console.ReadKey(true);
        }
    }
}