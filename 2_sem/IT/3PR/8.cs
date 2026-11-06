using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Нажмите на 'rect' для получения информации о прямоугольнике";
            string pattern = @"'\w+'";
            string replacement = @"<area shape='rect' /> $&";
            Console.WriteLine(Regex.IsMatch(data, pattern));
            string result = Regex.Replace(data, pattern, replacement);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}