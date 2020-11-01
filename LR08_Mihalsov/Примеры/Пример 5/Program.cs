using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myText = 
@"Сериализация представляет собой процесс сохранения объекта на диске.
В другой части приложения или даже в совершенно отдельном приложении может производиться десериализация объекта, возвращающая его в состояние, в котором он пребывал до сериализации.";
            const string myReg = "со";
            MatchCollection myMatch = Regex.Matches(myText, myReg);
            Console.WriteLine("Все вхождения строки \"{0}\" в исходной строке: ",myReg);
        foreach (Match i in myMatch)
                Console.Write("\t" + i.Index);
            // Усложним шаблон регулярного выражения
            // введя в него специальные метасимволы
            const string myReg1 = @"\b[с,д]\S*ериализац\S*";
            MatchCollection match1 =
           Regex.Matches(myText, myReg1, RegexOptions.IgnoreCase);
            findMyText(myText, match1);

            Console.ReadKey(true);
        }
        static void findMyText(string text, MatchCollection myMatch)
        {
            Console.WriteLine("\n\nИсходная строка:\n\n{0}\n\nВидоизмененная строка:\n",text);
        // Реализуем выделение ключевых слов в консоли другим цветом
        for (int i = 0; i < text.Length; i++)
            {
                foreach (Match m in myMatch)
                {
                    if ((i >= m.Index) && (i < m.Index + m.Length))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Write(text[i]);
            }

        }
    }
}