using System;
class Program
{
    static double sum(params double[] a)
    {
        double sum = 0.0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += Math.Pow(a[i], 1.0 / 3.0);
        }
        return sum;
    }
    public static void Main()
    {
        Console.WriteLine("Введите количество чисел:");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] a = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите {i + 1} число:");
            a[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"Сумма = {sum(a)}");
    }
}