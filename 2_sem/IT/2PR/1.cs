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
            string data0 = "капуста";
            string data1 = "капусто";
            string data2 = "копуста";
            Regex regex = new Regex(@"к[ао]пуст[ао]");
            Console.WriteLine(regex.IsMatch(data0));
            Console.WriteLine(regex.IsMatch(data1));
            Console.WriteLine(regex.IsMatch(data2));
            Console.ReadKey();
        }
    }
}
    