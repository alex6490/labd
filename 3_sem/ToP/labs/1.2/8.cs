using System;
public class Program
{
    public static void Main()
    {
        double e = 1e-5;
        double x = Math.PI / 6;
        double sum = 0;
        double term = 1;
        int n = 1;
        do
        {
            term = term * (-x * x) / ((2 * n - 1) * (2 * n));
            sum += term;
            n++;
        }
        while (Math.Abs(term) >= e);
        Console.WriteLine($"Сумма ряда: {sum}");
    }
}