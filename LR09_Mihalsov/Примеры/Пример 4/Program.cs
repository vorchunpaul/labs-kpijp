using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    public struct Book
    {
        // members
        public string Name;
        public int Price;
        // constructor
        public Book(String name, int price)
        {
            Name = name;
            Price = price;
        }
        // methods
        public void Show()
        {
            Console.WriteLine("Название книги {0}, Цена {1}", Name, Price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // создаем объект структуры с оператором new без параметров
            Book book = new Book();
            // конструктор по умолчанию установит значения
            // Name = ""
            // Price = 0
            // Показываем результат на экране
            book.Show();
            Console.ReadKey();
        }
    }
}