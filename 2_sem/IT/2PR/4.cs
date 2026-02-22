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
            string data0 = "капуста стоит 100 рублей";
            string data1 = "у нас не выросла капуста";
            string data2 = "капуста цветная";
            string data3 = "морская капуста";
            Regex regex = new Regex(@"\Aкапуста");
            Console.WriteLine(regex.IsMatch(data0));
            Console.WriteLine(regex.IsMatch(data1));
            Console.WriteLine(regex.IsMatch(data2));
            Console.WriteLine(regex.IsMatch(data3));
            Console.ReadKey();
        }
    }
}