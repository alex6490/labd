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
            Regex regex = new Regex(@"^[a-z0-9]+@[a-z0-9]+\.[a-z]+$", RegexOptions.IgnoreCase);
            Console.WriteLine(regex.IsMatch("fomaxandr@gmail.com"));
            Console.WriteLine(regex.IsMatch("alexandr fomin000@ya.ru"));
            Console.WriteLine(regex.IsMatch("alфомин649@yandex.ru"));
            Console.ReadKey();
        }
    }
}