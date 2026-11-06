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
            Regex mr = new Regex(@"\b(?:(?>сдается()|студент()|экзамен()|(?>\1|\2|\3)\w+)\b\W*?){1,5}\1\2\3"
            , RegexOptions.IgnoreCase);
            Console.WriteLine(mr.IsMatch("Студент сдается, не сдаст экзамен"));
            Console.WriteLine(mr.IsMatch("Не сдается упорный студент чтобы сдать экзамен"));
            Console.ReadKey();
        }
    }
}