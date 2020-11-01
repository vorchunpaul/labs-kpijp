using System;
using System.Text.RegularExpressions;
class Example
{
    static void Main()
    {
        string[] test = {"Wuck World", "Hello world", "My wonderful world"};

        Regex regex = new Regex("World");
        Console.WriteLine("Регистрозависимый поиск: ");
        foreach (string str in test)
        {
            if (regex.IsMatch(str))
                Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
        }
        Console.WriteLine();

        regex = new Regex("World", RegexOptions.IgnoreCase);
        Console.WriteLine("Регистро НЕ зависимый поиск: ");
        foreach (string str in test)
        {
            if (regex.IsMatch(str))
                Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
        }

        Console.ReadKey(true);
    }
}