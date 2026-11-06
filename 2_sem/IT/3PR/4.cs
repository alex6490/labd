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
            string data1 = "<form>Сегодня будет лекция по теме Regex</form>";
            string data2= "<form>Завтра будет дождь</form>";
            string data3 = "<form>Лекции не будет из-за праздников</form>";
            string data4 = "<div>Скоро начнется пара</div>";
            Regex formRegex = new Regex(@"<form>.*?</form>");
            Console.WriteLine(formRegex.IsMatch(data1));
            Console.WriteLine(formRegex.IsMatch(data2));
            Console.WriteLine(formRegex.IsMatch(data3));
            Console.WriteLine(formRegex.IsMatch(data4));
            Console.ReadKey();
        }
    }
}