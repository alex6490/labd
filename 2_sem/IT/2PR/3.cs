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
            string data0 = "0";
            string data1 = "9";
            string data2 = "F";
            Regex regex = new Regex(@"[^0-7]");
            Console.WriteLine(regex.IsMatch(data0));
            Console.WriteLine(regex.IsMatch(data1));
            Console.WriteLine(regex.IsMatch(data2));
            Console.ReadKey();
        }
    }
}
    