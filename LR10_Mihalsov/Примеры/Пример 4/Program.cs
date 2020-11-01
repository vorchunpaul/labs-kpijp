using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ProfessorWeb
    {
        const string ADDR = "http:\\professorweb.ru";
        public string level, inLevel;
        public int numberSt;
        private string inf;

        public void InfoPW()
        {
            Console.WriteLine("Сайт: {0}\nРаздел: {1}\nПодраздел: {2}\nКолво статей:{3}", ADDR, level, inLevel, numberSt);
        }
    }

    // Объявляем класс, унаследованный от класса ProfessorWeb     
    class CSharp : ProfessorWeb
    {
        public string st;

        // 	Поля 	класса 	ProfessorWeb 	доступны 	через 	конструктор наследуемого класса 
        public CSharp(string level, string inLevel, int numberSt, string st)
        {
            this.level = level;
            this.inLevel = inLevel;
            this.numberSt = numberSt;
            this.st = st;
        }

        public void StWrite()
        {
            Console.WriteLine("Статья: " + st);
        }
    }

    class Program
    {
        static void Main()
        {
            CSharp obj = new CSharp(level: "C#", inLevel: "Перегрузка", numberSt: 7, st: "Перегрузка методов");
            obj.InfoPW();
            obj.StWrite();

            Console.ReadLine();
        }
    }
}
