using System;
class Program
{
    static double sum(ref int k, ref double x)
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
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите k:");
        int k1 = Convert.ToInt32(Console.ReadLine());
        double result = sum(ref k1, ref x1);
        Console.WriteLine($"Сумма = {result}");
    }
}