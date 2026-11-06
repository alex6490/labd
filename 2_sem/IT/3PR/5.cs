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
            string data1 = "<html><head><title>Программа</title>↵</head><body><p>Hello, World!</p></body></html>";
            string data2 = "<html><head><title>Портал</title>↵</head><body><h2>Добро пожаловать</h2></body></html>";
            string data3 = "<html><head><title>Блог</title>↵</head><body><div>Видео</div></body></html>";
            string data4 = "<html><head><title>Проверка</title>↵</head><body><span>Здесь могла бы быть ваша реклама</span></body></html>";
            string data5 = "<html><head><title>Другое</title>↵</head><body><p>Больше информации</p></body></html>";
            string data6 = "<html><head><title>Показать больше</title>↵</head><body><h2>Поделиться</h2></body></html>";
            Regex myReg = new Regex(
                @"<html>(?>.*?<head>)(?>.*?<title>)(?>.*?</title>)↵(?>.*?</head>)(?>.*?<body[^>]*>)(?>.*?<h2[^>]*>)(?>.*?</h2>)(?>.*?</body>).*?</html>"
                );
            Console.WriteLine(myReg.IsMatch(data1));
            Console.WriteLine(myReg.IsMatch(data2));
            Console.WriteLine(myReg.IsMatch(data3));
            Console.WriteLine(myReg.IsMatch(data4));
            Console.WriteLine(myReg.IsMatch(data5));
            Console.WriteLine(myReg.IsMatch(data6));
            Console.ReadKey();
        }
    }
}