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
            // создаем структуру без оператора new
            Book book;
            // инициализируем данные класса
            book.Name = "Волшебник Земноморья";
            book.Price = 70;
            // Показываем результат на экране
            book.Show();
            Console.ReadKey();
        }
    }
}