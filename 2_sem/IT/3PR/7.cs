using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string data1 = "На прилавке магазина есть банан, груша, киви, ананас, апельсин, персик";
            string data2 = "Вчера в магазин привезли банан, груша, киви, ананас, апельсин, персиков";
            string data3 = "Сегодня в магазине продается банан, груша, киви, ананас, апельсин, персик";
            Regex myrex = new Regex(
                @"\b(?:(?:(банан)|(груша)|(киви)|(ананас)|(апельсин)|(персик))(?:, |\b)){6,}(?(1)|(?!))(?(2)|(?!))(?(3)|(?!))(?(4)|(?!))(?(5)|(?!))(?(6)|(?!))", 
                RegexOptions.IgnoreCase);
            Console.WriteLine(myrex.IsMatch(data1));
            Console.WriteLine(myrex.IsMatch(data2));
            Console.WriteLine(myrex.IsMatch(data3));
            Console.ReadKey();
        }
    }
}