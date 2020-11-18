using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = 18;
            int KK = 5;
            string path1 = @"F1.txt";
            string path2 = @"F2.txt";
            StreamReader sr = new StreamReader(path1);
            for (int i = 1; i < K; i++) sr.ReadLine();

            using (StreamWriter sw = new StreamWriter(path2, false))
            {
                for (int i = 0; i < KK; i++)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                    sw.WriteLine(line);
                }
            }

            sr = new StreamReader(path2);
            Regex reg = new Regex(@"[ауоыиэяюёе]");
            string text = sr.ReadToEnd();
            MatchCollection matchs = reg.Matches(text);

            Console.WriteLine("\nКоличество гласный букв в {0} составило {1}", path2, matchs.Count);
            Console.ReadKey(true);
        }
    }
}
