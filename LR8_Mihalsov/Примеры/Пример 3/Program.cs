using System;
using System.Text.RegularExpressions;
class Example
{
    static void Main()
    {
        // Допустим в исходной строке нужно найти все числа,
        // соответствующие стоимости продукта
        string input = "Добро пожаловать в наш магазин, вот наши цены: " +
        "1 кг. яблок - 20 руб. " +
        "2 кг. апельсинов - 30 руб. " +
        "0.5 кг. орехов - 50 руб.";
        string pattern = @"\b(\d+\W?руб)";
        Regex regex = new Regex(pattern);
        // Достигаем того же результата что и в предыдущем примере,
        // используя метод Regex.Matches() возвращающий MatchCollection
        foreach (Match match in regex.Matches(input))
        {
            Console.WriteLine(match.Groups[1].Value);
        }

        Console.ReadKey(true);
    }
}