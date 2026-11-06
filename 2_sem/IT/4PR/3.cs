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
            Regex mr = new Regex(@"^\+(?:[0-9]*?){6,14}[0-9]$");
            Console.WriteLine(mr.IsMatch("+780123456789"));
            Console.WriteLine(mr.IsMatch("560123456789"));
            Console.ReadKey();
        }
    }
}