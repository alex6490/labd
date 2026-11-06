using System;
class Program
{
    static int f(int n)
    {
        int f1 = 1;
        if (n == 1) return f1;
        int fn = f(n - 1) + (int)Math.Pow(2, n - 1);
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
        Console.WriteLine($"f({n}) = {f(n)}");
    }
}