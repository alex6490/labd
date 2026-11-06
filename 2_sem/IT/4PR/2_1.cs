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
            string phn = "12345678901";
            Regex myrex = new Regex(@"^\(?([0-9]{4})\)?([0-9]{3})?([0-9]{4})$");
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