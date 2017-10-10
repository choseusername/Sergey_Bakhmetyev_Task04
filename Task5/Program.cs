using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        public static string ReplaceHTMLTags(string input, string replacement)
        {
            return Regex.Replace(input, "<.*?>", replacement);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите HTML текст: ");
            string html = Console.ReadLine();
            Console.WriteLine("Результат замены: {0}", ReplaceHTMLTags(html, "_"));
            Console.ReadKey();
        }
    }
}
