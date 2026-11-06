using System;
class Program
{
    static void an(ref double[] a, ref double pr, ref int anof)
    {
        pr = 1;
        anof = 0;
        foreach (var el in a)
        {
            if (el % 7 == 0)
            {
                pr *= el;
                anof++;
            }
        }
    }
    public static void Main()
    {
        Console.WriteLine("Введите количество элементов массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] a = new double[n];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToDouble(Console.ReadLine());
        }
        int m = 0;
        double p = 0.0;
        an(ref a, ref p, ref m);
        Console.WriteLine($"Произведение элементов, кратных 7 = {p}");
        Console.WriteLine($"Количество элементов, кратных 7 = {m}");
    }
}