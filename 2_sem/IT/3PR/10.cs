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
            string pattern = @"Курсовая";
            string replacement = @"$`$_$'";
            string data = "ЛабораторнаяКурсоваяЗачетЭкзамен";
            string result = Regex.Replace(data, pattern, replacement);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}