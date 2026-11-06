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
            string dat0 = "156a";
            string dat1 = "46b";
            string dat2 = "14f";
            string dat3 = "abf46785665cd434555747457457afdca566";
            Regex hex = new Regex(@"\b[a-f0-9]{1,32}\b", RegexOptions.IgnoreCase);
            Console.WriteLine(hex.IsMatch(dat0));
            Console.WriteLine(hex.IsMatch(dat1));
            Console.WriteLine(hex.IsMatch(dat2));
            Console.WriteLine(hex.IsMatch(dat3));
            Console.ReadKey();
        }
    }
}