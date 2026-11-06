using System;
class Program
{
    static double sum(int k, double x)
    {
        double sum = 0.0;
        for (int p = 1; p <= k; p++)
        {
            sum+=Math.Cos(2*Math.Pow(p, 2)-x);
        }
        return sum;
    }
    public static void Main()
    {
        Console.WriteLine("Введите x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите k:");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Сумма = {sum(k, x)}");
    }
}