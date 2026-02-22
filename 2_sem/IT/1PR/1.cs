using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data1 = "Алешкин, Пушкин, Иванцов, Иванов";
            string data2 = "Иванников, Петров, Кузнецов, Сидоров";
            Regex myregul = new Regex("Иванов");
            Console.WriteLine(myregul.IsMatch(data1));
            Console.WriteLine(myregul.IsMatch(data2));
            Console.ReadKey();
        }
    }
}