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
            string phn = "623456789";
            Regex myrex = new Regex(@"^\(?([5-9][1-9][0-9])\)?([1-9][2-9][0-9])?([1-9][0-9][1-9])$");
            if (myrex.IsMatch(phn))
            {
                string newphn = myrex.Replace(phn, "($1) $2-$3");
                Console.WriteLine("исходный номер телефона: " + phn);
                Console.WriteLine("Форматированный номер телефона: " + newphn);
            }
            else
            {
                Console.WriteLine("Номер телефона не соответствует шаблону");
            }
        }
    }
}