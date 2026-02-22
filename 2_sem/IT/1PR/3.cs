using System.Text.RegularExpressions;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Иванов, Алешкин, Пушкин, Иванцов, Иванов";
            Regex myregul = new Regex("Иванов");
            MatchCollection matches = myregul.Matches(data);
            Console.WriteLine(matches.Count);
            foreach (Match m in matches)
                Console.WriteLine(m.Value);
            Console.ReadKey();
        }
    }
}