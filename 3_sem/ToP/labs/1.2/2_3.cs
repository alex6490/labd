using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите верхний предел: ");
        int k = Convert.ToInt32(Console.ReadLine());

        double sum = 0;
        int p = 1;

        do
        {
            sum += Math.Cos(3 * p * p + x);
            p++;
        }
        while (p <= k);

        Console.WriteLine($"Сумма: {sum}");
    }
}