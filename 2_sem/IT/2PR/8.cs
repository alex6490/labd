using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string data0 = "порт";
            string data1 = "портовый";
            string data2 = "северный порт";
            string data3 = "портной сшил мне костюм";
            Regex regex = new Regex(@"\bпорт\b");
            Console.WriteLine(regex.IsMatch(data0));
            Console.WriteLine(regex.IsMatch(data1));
            Console.WriteLine(regex.IsMatch(data2));
            Console.WriteLine(regex.IsMatch(data3));
            Console.ReadKey();
        }
    }
}