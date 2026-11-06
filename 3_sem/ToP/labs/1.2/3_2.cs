using System;

public class Program
{
    public static void Main()
    {
        double x, y, z, xn, xk, yn, yk, hx, hy;

        Console.WriteLine("Введите значение xn: ");
        xn = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение xk: ");
        xk = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение hx: ");
        hx = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение yn: ");
        yn = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение yk: ");
        yk = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение hy: ");
        hy = Convert.ToDouble(Console.ReadLine());

        x = xn;

        while (x <= xk)
        {
            y = yn;

            while (y <= yk)
            {
                z = x * x * x + 2 * x - 3 * y + 5 * x * x;

                Console.WriteLine($"z = {z} при x = {x} y = {y}");

                y += hy;
            }

            x += hx;
        }
    }
}