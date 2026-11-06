using System;
class Program
{
    static int f(int n)
    {
        Console.WriteLine($"вычисление рекурсии от n = {n}");
        if (n == 1)
        {
            Console.WriteLine($"Вычислили f({n}) = 1");
            return 1;
        }
        int fn = f(n - 1) + (int)Math.Pow(2, n - 1);
        Console.WriteLine($"Вычислили f({n}) = {fn}");
        return fn;
    }
    public static void Main()
    {
        Console.WriteLine("Введите n:");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n<1)
        {
            Console.WriteLine("По условию n > 1");
            return;
        }
        Console.WriteLine($"рекурсивная функция {n} = {f(n)}");
    }
}