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
            string dta1 = "<h2>Поздравляем</h2> с наступающим праздником!";
            string dta2 = "<h2>Расписание</h2> занятий студетнов кафедры АСУ ";
            string dta3 = "<h2>Введение в регулярные выражения - важная тема для изучения!";
            Regex myReg = new Regex(@"(?<=<h2>)\w+(?=</h2>)", RegexOptions.IgnoreCase);
            Console.WriteLine(myReg.IsMatch(dta1));
            Console.WriteLine(myReg.IsMatch(dta2));
            Console.WriteLine(myReg.IsMatch(dta3));
            Console.ReadKey();
        }
    }
}