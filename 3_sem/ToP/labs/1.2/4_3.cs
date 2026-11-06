using System;

public class Program
{
    public static void Main()
    {
        double x, k, b, sum, z;

        Console.WriteLine("Введите значение x: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите верхний предел k: ");
        k = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите верхний предел b: ");
        b = Convert.ToDouble(Console.ReadLine());

        sum = 0;

        for (int p = 1; p <= k; p++)
        {
            for (int w = 1; w <= b; w++)
            {
                z = (3 * w + p) / (Math.Pow(2, w) + Math.Sin(4 * x));
                sum += z;
            }
        }

        Console.WriteLine($"I = {sum}");
    }
}