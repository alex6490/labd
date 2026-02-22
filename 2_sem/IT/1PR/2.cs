using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Алешкин, Пушкин, Иванцов, Иванов";
            Regex myregul = new Regex("Иванов");
            Match match = myregul.Match(data);
            Console.WriteLine(match.Value);
            Console.WriteLine(match.Index);
            Console.ReadKey();
        }
    }
}