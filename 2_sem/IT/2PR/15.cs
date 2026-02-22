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
            string date0 = "2007.01.19";
            string date1 = "2007.07.07";
            string date2 = "2007.01.09";
            Regex regdate = new Regex(@"\b\d\d(?<magic>\d\d)\.\k<magic>\.\k<magic>\b");
            Console.WriteLine(regdate.IsMatch(date0));
            Console.WriteLine(regdate.IsMatch(date1));
            Console.WriteLine(regdate.IsMatch(date2));
            string[] names = regdate.GetGroupNames();
            foreach (string n in names)
                Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}