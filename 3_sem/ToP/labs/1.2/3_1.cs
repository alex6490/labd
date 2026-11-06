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

        for (x = xn; x <= xk; x += hx)
        {
            for (y = yn; y <= yk; y += hy)
            {
                z = x * x * x + 2 * x - 3 * y + 5 * x * x;

                Console.WriteLine($"x = {x}; y = {y}; z = {z}");
            }
        }
    }
}