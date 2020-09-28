using System;
class Example
{
    static void Main()
    {
        string str1 = "alpha";
        string str2 = "Alpha";
        string str3 = "Beta";
        string str4 = "alpha";
        string str5 = "alpha, beta";
        int result;

        // Сначала продемонстрировать отличия между сравнением строк
        // с учетом культурной среды и порядковым сравнением
        result = String.Compare(str1, str2, StringComparison.CurrentCulture);
        Console.Write("Сравнение строк с учетом культурной среды: ");

        if (result < 0)
            Console.WriteLine(str1 + " меньше " + str2);
        else if (result > 0)
            Console.WriteLine(str1 + " больше " + str2);
        else
            Console.WriteLine(str1 + " равно " + str2);

        result = String.Compare(str1, str2, StringComparison.Ordinal);
        Console.Write("Порядковое сравнение строк: ");
        if (result < 0)
            Console.WriteLine(str1 + " меньше " + str2);
        else if (result > 0)
            Console.WriteLine(str1 + " больше " + str2);
        else
            Console.WriteLine(str1 + " равно " + str4);
        // Использовать метод CompareOrdinal()
        result = String.CompareOrdinal(str1, str2);
        Console.Write("Сравнение строк методом CompareOrdinal():\n");
        if (result < 0)
            Console.WriteLine(str1 + " меньше " + str2);
        else if (result > 0)
            Console.WriteLine(str1 + " больше " + str2);
        else
            Console.WriteLine(str1 + " равно " + str4);
        Console.WriteLine();
        // Определить равенство строк с помощью оператора ==
        // Это порядковое сравнение символьных строк
        if (str1 == str4)
            Console.WriteLine(str1 + " == " + str4);
        // Определить неравенство строк с помощью оператора !=
        if (str1 != str3)
            Console.WriteLine(str1 + " != " + str3);

        if (str1 != str2)
            Console.WriteLine(str1 + " != " + str2);
        Console.WriteLine();

        // Выполнить порядковое сравнение строк без учета регистра,
        // используя метод Equals()
        if (String.Equals(str1, str2, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("Сравнение строк методом Equals() с " +
            "параметром OrdinalIgnoreCase:\n" +
            str1 + " равно " + str2);
        Console.WriteLine();
        // Сравнить части строк
        if (String.Compare(str2, 0, str5, 0, 3,
        StringComparison.CurrentCulture) > 0)
        {
            Console.WriteLine("Сравнение строк с учетом текущей культурной среды: " +
            "\n3 первых символа строки " + str2 +
            " больше, чем 3 первых символа строки " + str5);
        }

        Console.ReadKey(true);
    }
}