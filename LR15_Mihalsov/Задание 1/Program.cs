using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.txt";
            StreamReader sr = new StreamReader(path);
            string text = sr.ReadToEnd();
            Console.WriteLine("Текст до обработки:  \n{0}\n",text);
            Regex reg;
            reg = new Regex(@"\s{2,}");
            text = reg.Replace(text, " ");
            reg = new Regex(@"[.!?][ ]");
            text = reg.Replace(text, ".\n");
            Console.WriteLine("Текст после обработки:  \n{0}", text);
            Console.ReadKey(true);
        }
    }
}
