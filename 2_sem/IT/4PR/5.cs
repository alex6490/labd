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
            Regex rg = new Regex(@"^\W*(?:\w+\b\W*){5,9}$");
            Console.WriteLine(rg.IsMatch("Hello world!"));
            Console.WriteLine(rg.IsMatch("Hello world! Hello world!"));
            Console.WriteLine(rg.IsMatch("Hello world! Hello world! Hello world!"));
            Console.ReadKey();
        }
    }
}