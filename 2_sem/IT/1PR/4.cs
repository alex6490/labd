using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Иванов, Алешкин, Пушкин, Иванцов, Иванов";
            Regex myregul = new Regex("Иванов");
            data = myregul.Replace(data, "Иванушкин");
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}