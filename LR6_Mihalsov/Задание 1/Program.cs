using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void printArr(int[] arr, string msg = "")
        {
            if(msg != "")
                Console.WriteLine("{0}:",msg);
            Console.Write("[");
            foreach (var i in arr)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine("\b\b]");
        }

        static string printIt(int it, int mask, char spaser)
        {
            StringBuilder outIt = new StringBuilder(it.ToString());
            while (outIt.Length != mask.ToString().Length)
            {
                outIt.Insert(0, spaser);
            }
            return outIt.ToString();
        }

        static void Main(string[] args)
        {
            int MAXVALUE = 100;
            int MINVALUE = -100;
            uint N = 10;

            uint min_i = 0;
            int min_sum = 0;

            /*            Console.Write("Введите количество точек: ");
                        ushort N = ushort.Parse(Console.ReadLine()); // Количество точек*/

            int[] arr = new int[N]; // Массив точек


            Random rand = new Random();

            for(ushort i = 0; i < arr.Length; ++i)
            {
                arr[i] = rand.Next(MINVALUE, MAXVALUE);
            }

            Array.Sort(arr);
            printArr(arr, "Точки");
            Console.WriteLine("\nСумма растояний для каждой точки:");

            bool isInitSum = false;
            min_i = 0;
            min_sum = arr[0];

            for (ushort i = 0; i < arr.Length;  ++i)
            {
                Console.Write("{0} ->\t", printIt(arr[i], MAXVALUE * 10 * 10, ' '));

                int sum = 0;

                foreach (var ii in arr)
                {
                    int distanse = Math.Abs(ii - arr[i]);
                    sum += distanse;
                    Console.Write("{0}, ", printIt(distanse,MAXVALUE, ' '));
                }

                if(!isInitSum)
                {
                    min_sum = sum;
                    isInitSum = true;
                }

                if(sum < min_sum && isInitSum)
                {
                    min_sum = sum;
                    min_i = i;
                }

                Console.WriteLine("\b\b =\t {0}", sum);
            }

            Console.WriteLine("\nМинимальная сумма = {0}", min_sum);
            Console.WriteLine("Порядковый номер точки с минимальной суммой = {0}", min_i + 1);
            Console.WriteLine("Точка с минимальной суммой = {0}", arr[min_i]);

            Console.WriteLine("\n{{sum={0}, i={1}, point={2}}}\n", min_sum, min_i, arr[min_i]);

            Console.ReadKey(true);
        }
    }
}
