using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "иванов, Алешкин, Пушкин, Иванцов";
            Regex myregulIgnorshik = new Regex(@"Иванов", RegexOptions.IgnoreCase);
            Regex myregul = new Regex(@"Иванов");
            Console.WriteLine(myregulIgnorshik.IsMatch(data));
            Console.WriteLine(myregul.IsMatch(data));
            Console.ReadKey();
        }
    }
}