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
            string pattern = @"\b(?<areaCode>\d{5})(?<firstPart>\d{3})(?<secondPart>\d{2})(?<thirdPart>\d{2})\b";
            string replacement = @"(${areaCode})${firstPart}-${secondPart}-${thirdPart}";
            string data = "123456789012";
            string result = Regex.Replace(data, pattern, replacement);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}