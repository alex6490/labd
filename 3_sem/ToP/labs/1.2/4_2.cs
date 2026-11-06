using System;

public class Program
{
    public static void Main()
    {
        double x, k, b, sum, p, w, z;

        Console.WriteLine("Введите значение x: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите верхний предел k: ");
        k = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите верхний предел b: ");
        b = Convert.ToDouble(Console.ReadLine());

        sum = 0;
        p = 1;

        do
        {
            w = 1;

            do
            {
                z = (3 * w + p) / (Math.Pow(2, w) + Math.Sin(4 * x));
                sum += z;

                w++;
            }
            while (w <= b);

            p++;
        }
        while (p <= k);

        Console.WriteLine($"I = {sum}");
    }
}