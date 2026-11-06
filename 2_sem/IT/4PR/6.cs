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
            string data1 = "дА";
            string data2 = "Ладно";
            Regex myReg = new Regex(@"^(?:д(?:а)?|л(?:адно)?|и(?:стина)?)$", RegexOptions.IgnoreCase);
            Console.WriteLine(myReg.IsMatch(data1));
            Console.WriteLine(myReg.IsMatch(data2));
            Console.ReadKey();
        }
    }
}