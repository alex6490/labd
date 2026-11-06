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
            string dat0 = "156.456545458656585685574323576967934346";
            string dat1 = "123";
            string dat2 = "789.012E-3";
            string dat3 = "456.789e+1";
            string dat4 = ".987654321";
            string dat5 = "987.654455656566566585678e+044554654747";
            Regex real = new Regex(@"\d*\.\d{1,16}(?:e[+-]\d{1,10})?$", RegexOptions.IgnoreCase);
            Console.WriteLine(real.IsMatch(dat0));
            Console.WriteLine(real.IsMatch(dat1));
            Console.WriteLine(real.IsMatch(dat2));
            Console.WriteLine(real.IsMatch(dat3));
            Console.WriteLine(real.IsMatch(dat4));
            Console.WriteLine(real.IsMatch(dat5));
            Console.ReadKey();
        }
    }
}