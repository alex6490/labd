using System;
class Program
{
    static int f(int n)
    {
        Console.WriteLine($"вычисление рекурсии от n = {n}");
        if (n<=2)
        {
            Console.WriteLine($"Вычислили f({n}) = 2");
            return 2;
        }
        int fn = 2*f(n-1)+f(n-2);
        Console.WriteLine($"Вычислили f({n}) = {fn}");
        return fn;
    }
    public static void Main()
    {
        Console.WriteLine("Введите n:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"рекурсивная функция {n} = {f(n)}");
    }
}