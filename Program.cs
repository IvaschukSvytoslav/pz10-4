using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Створення колекції доменних імен
        List<string> websites = new List<string>
        {
            "https://example.com",
            "https://site.ru",
            "https://developer.msdn",
            "https://coolwebsite.ua",
            "https://blog.msdn",
            "https://another-site.net",
            "https://shop.ru",
            "https://service.org",
            "https://forum.msdn",
            "https://page.ru"
        };

        // Запит LINQ для відбору сайтів, які закінчуються на ".ru" або ".msdn"
        var filteredWebsites = websites.Where(site => site.EndsWith(".ru") || site.EndsWith(".msdn"));

        // Виведення результатів
        Console.WriteLine("Сайти, які закінчуються на '.ru' або '.msdn':");
        foreach (var site in filteredWebsites)
        {
            Console.WriteLine(site);
        }
    }
}
