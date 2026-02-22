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
           string data0 = "На столе лежали торт, пироженка и конфета";
           string data1 = "На столе лежали торт, пироженое и конфета. Пироженое было шоколадное.";
           Regex myregx = new Regex(@"\b(торт|пироженое|конфета)\b");
           Console.WriteLine(myregx.IsMatch(data0));
           MatchCollection matches0 = myregx.Matches(data0);
           Console.WriteLine(matches0.Count);
           foreach (Match m in matches0)
                Console.WriteLine(m.Value);
            Console.WriteLine(myregx.IsMatch(data1));
            MatchCollection matches1 = myregx.Matches(data1);
            Console.WriteLine(matches1.Count);
            foreach (Match m in matches1)                
                Console.WriteLine(m.Value);
            Console.ReadKey();
        }
           
    }
}