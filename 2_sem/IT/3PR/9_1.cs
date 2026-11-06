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
            string pattern = @"\b(\d{5})(\d{3})(\d{2})(\d{2})\b";
            string replacement = @"($1)$2-$3-$4";
            string data = "123456789012";
            string result = Regex.Replace(data, pattern, replacement);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}