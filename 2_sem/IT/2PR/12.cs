using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string dat0 = "2007.01.19";
            string dat1 = "2007-01-19";
            Regex regdat = new Regex(@"\b(\d\d\d\d)\.(\d\d)\.(\d\d)\b");
            Console.WriteLine(regdat.IsMatch(dat0));
            Console.WriteLine(regdat.IsMatch(dat1));
            Console.ReadKey();
        }
    }
}