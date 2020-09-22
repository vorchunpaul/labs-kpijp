using System;
class OverloadMethDemo
{
    static void show(string txt)
    {
        Console.WriteLine("Текст: " + txt);
    }
    static void show(int num)
    {
        Console.WriteLine("Целое число: " + num);
    }

    static void show(double num) { 
        Console.WriteLine("Действительное число: "+num); 
    }

    static void show(char s)
    {
        Console.WriteLine("Символ: " + s);
    }

    static void show(int num, char s)
    {
        Console.WriteLine("Аргументы {0} и {1}", num, s);
    }

    static void Main()
    {
        // Целочисленная переменная: 
        int num=5; 
        // Действительная числовая переменная:  
        double z=12.5; 
        // Символьная переменная:  
        char symb = 'W';
        // Вызываем метод с символьным аргументом: 
        show(symb);
        // Вызываем метод с текстовым аргументом: 
        show("Знакомимся с перегрузкой методов"); 
        show(num);
        // Вызываем метод с действительным аргументом: 
        show(z);
        // Вызываем метод с двумя аргументами: 
        show(num,'Q');

        Console.ReadKey(true);
    }
}