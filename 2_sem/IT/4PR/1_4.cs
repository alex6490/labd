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
            Regex regex = new Regex(
                @"^[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@[A-Z0-9-]+(?:\.[A-Z0-9-]+)*$",
                 RegexOptions.IgnoreCase);
            Console.WriteLine(regex.IsMatch("fomaxandr@gmail.com"));
            Console.WriteLine(regex.IsMatch("alexandr fomin000@ya.ru"));
            Console.WriteLine(regex.IsMatch("alfомин649@yandex.ru"));
            Console.ReadKey();
        }
    }
}