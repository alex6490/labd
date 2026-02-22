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
            string dates0 = "2007.01.19";
            string dates1 = "2007.01.19";
            string dates2 = "2007_01.09";
            Regex regdates = new Regex(@"\b(?<year>\d\d\d\d)\.(?<month>\d\d)\.(?<day>\d\d)\b");
            Console.WriteLine(regdates.IsMatch(dates0));
            Console.WriteLine(regdates.IsMatch(dates1));
            Console.WriteLine(regdates.IsMatch(dates2));
            string[] names = regdates.GetGroupNames();
            foreach (string n in names)
                Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}