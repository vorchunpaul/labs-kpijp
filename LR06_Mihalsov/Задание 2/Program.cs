using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int M = 5;
            int MAXVALUE = 0;
            int MINVALUE = -100;
            int maxStringLong; 
            
            if(MAXVALUE.ToString().Length >= MINVALUE.ToString().Length)
            {
                maxStringLong = MAXVALUE.ToString().Length;
            }
            else
            {
                maxStringLong = MINVALUE.ToString().Length;
            }

            string maxString= new string('0', maxStringLong);
            string FormatElem = maxString + ";" + "-" + maxString.Remove(0, 1) + ";" + maxString;

            int[,] Matrix = new int[N, M];
            int[] ArrOfPower = new int[N];
            int[] SortArrOfPower = new int[M];
            int[,] PowerSortMatrix = new int[N, M];


            // Заполняем матрицу случайными значениями
            Random rand = new Random();
            for(int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    Matrix[i, j] = rand.Next(MINVALUE, MAXVALUE);
                }
            }

            // Считаем сумму по столбцам и записываем их массив
            for(int i = 0; i < M; ++i)
            {
                int SumOfCol = 0;
                for (int j = 0; j < N; ++j)
                {
                    if(Matrix[i,j] < 0 && Matrix[i, j] % 2 != 0)
                    {
                        SumOfCol += Math.Abs(Matrix[i, j]);
                    }
                }

                ArrOfPower[i] = SumOfCol;
            }

            // Копируем массив с суммами в новый массив
            Array.Copy(ArrOfPower, SortArrOfPower, ArrOfPower.Length);
            
            // Сортируем значения в массиве
            Array.Sort(SortArrOfPower);

            // Записываем новую матрицу в таблицу
            // Создаём переменную для столбцов матрицы
            int ii = 0;
            // Проходим по отсоритрованному массиву
            foreach (var colum in SortArrOfPower)
            {
                // Ищем элемент в неотсорированном масиве (столбец)   
                int i = Array.IndexOf(ArrOfPower, colum);

                // Перезаписываем значения в новую матрицу
                for (int j = 0; j < N; ++j)
                {
                    PowerSortMatrix[ii, j] = Matrix[i, j];
                }

                ii++;
            }

            // Выводим матрицы
            for (int j = 0; j < M; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.Write(String.Format(Matrix[i, j].ToString(FormatElem) + " "));
                }

                if(j == M % 2)
                {
                    Console.Write("   ->   ");
                }
                else
                {
                    Console.Write("        ");
                }

                for (int i = 0; i < N; i++)
                {
                    Console.Write(String.Format(PowerSortMatrix[i, j].ToString(FormatElem) + " "));
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (var i in ArrOfPower)
                Console.Write(i.ToString(FormatElem) + " ");

            Console.Write("        ");
            foreach (var i in SortArrOfPower)
                Console.Write(i.ToString(FormatElem) + " ");

            Console.WriteLine();
            double n = 9.3;
            Console.ReadKey(true);
        }
    }
}
