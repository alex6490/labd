using System.Text.RegularExpressions;

{
    Regex myReg = new Regex(@"[A-Za-z]+[\.A-Za-z0-9_-]*[A-Za-z0-9_-]+@[A-Za-z]+\.[A-Za-z]");
    Console.WriteLine(myReg.IsMatch("alexandr013.0@yandex.ru"));
    Console.WriteLine(myReg.IsMatch("alexandsrmail.ru"));
    Console.WriteLine(myReg.IsMatch("fominas465_1@fastmailcom"));
    Console.ReadLine();
}