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
           Regex myReg = new Regex(@"\b(?:экзамен\W+(?:\w+\W+){0,4}?сдается|сдается\W+(?:\w+\W+){0,4}?экзамен)\b"
           ,RegexOptions. IgnoreCase);
           Console.WriteLine(myReg.IsMatch("Экзамен не сдается"));
           Console.WriteLine(myReg.IsMatch("Не сдается студент перед очень сложным экзаменом"));
           Console.ReadKey();
        }
    }
}