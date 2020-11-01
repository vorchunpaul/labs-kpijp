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
        // Получаем совпадения в экземпляре класса Match
        Match match = regex.Match(input);
        // отображаем все совпадения
        while (match.Success)
        {
            // Т.к. мы выделили в шаблоне одну группу (одни круглые скобки),
            // ссылаемся на найденное значение через свойство Groups класса Match
            Console.WriteLine(match.Groups[1].Value);
            // Переходим к следующему совпадению
            match = match.NextMatch();
        }

        Console.ReadKey(true);
    }
}