using System.Text.RegularExpressions;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Иванов^Алешкин^Пушкин^Иванцов^Иванов";
            Regex myr = new Regex("\\^");
            string[] names = myr.Split(data);
            foreach (string m in names)
                Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}