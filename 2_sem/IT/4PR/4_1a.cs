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
            
            string data1 = "04/02/2025";
            string data2 = "02/31/21";
            string data3 = "02/01/2026";
            Regex myReg = new Regex(@"^(?:
                # Февраль (29 дней)
                (?<day>02)/(?<month>[12][0-9]|0[1-9])
                |
                # По 30 дней
                (?<day>0?[469]|11)/(?<month>30|[12][0-9]|0[1-9])
                |
                # По 31 день
                (?<day>0?[13578]|1[02])/(?<month>3[01]|[12][0-9]|0[1-9])
                )
                # Год
                /(?<year>((?:[0-9]{2})?[0-9]{2}))$", RegexOptions.IgnorePatternWhitespace);
            Console.WriteLine(myReg.IsMatch(data1));
            Console.WriteLine(myReg.IsMatch(data2));
            Console.WriteLine(myReg.IsMatch(data3));
            Console.ReadKey();
            }
        }
    }