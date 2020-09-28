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
            // Сравним первые две строки
            string s1 = "это строка";
            string s2 = "это текст, а это строка";
            if (String.CompareOrdinal(s1, s2) != 0)
                Console.WriteLine("Строки s1 и s2 не равны");
            if (String.Compare(s1, 0, s2, 13, 10, true) == 0)
                Console.WriteLine("При этом в них есть одинаковый текст");
            // Конкатенация строк
            Console.WriteLine(String.Concat("\n" + "Один, два ", "три, четыре"));
        // Поиск в строке
        // Первое вхождение подстроки
            if (s2.IndexOf("это") != -1)
                Console.WriteLine("Слово \"это\" найдено в строке, оно " +
                "находится на: {0} позиции", s2.IndexOf("это"));
            // Последнее вхождение подстроки
            if (s2.LastIndexOf("это") != -1)
                Console.WriteLine("Последнее вхождение слова \"это\" находится "
                + "на {0} позиции", s2.LastIndexOf("это"));
            // Поиск из массива символов
            char[] myCh = { 'Ы', 'х', 'т' };
            if (s2.IndexOfAny(myCh) != -1)
                Console.WriteLine("Один из символов из массива ch " +
                "найден в текущей строке на позиции {0}",
               s2.IndexOfAny(myCh));

            // Определяем начинается ли строка с заданной подстроки
            if (s2.StartsWith("это текст") == true)
                Console.WriteLine("Подстрока найдена!");
            // Определяем содержится ли в строке подстрока
            // на примере определения ОС пользователя
            string myOS = Environment.OSVersion.ToString();
            if (myOS.Contains("NT 5.1"))
                Console.WriteLine("Ваша операционная система Windows XP");
            else if (myOS.Contains("NT 6.1"))
                Console.WriteLine("Ваша операционная система Windows 7");

            Console.ReadLine();
        }
    }
}