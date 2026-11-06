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
            
            string data1 = "04/02/25";
            string data2 = "02/31/2011";
            string data3 = "02/01/2026";
            Regex myReg = new Regex(@"^(?:
                # Февраль (29 дней)
                (?<month>02)/(?<day>[12][0-9]|0[1-9])
                |
                # По 30 дней
                (?<month>0?[469]|11)/(?<day>30|[12][0-9]|0[1-9])
                |
                # По 31 день
                (?<month>0?[13578]|1[02])/(?<day>3[01]|[12][0-9]|0[1-9])
                )
                # Год
                /(?<year>(?:[0-9]{2})?[0-9]{2})$", RegexOptions.IgnorePatternWhitespace);
                Console.WriteLine(myReg.IsMatch(data1));
                Console.WriteLine(myReg.IsMatch(data2));
                Console.WriteLine(myReg.IsMatch(data3));
                Console.ReadKey();
            }
        }
    }