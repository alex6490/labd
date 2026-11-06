using System;
class Program
{
    static void an(in double[] a, out double pr, out int anof)
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
        double pr;
        int anof;
        an(a, out pr, out anof);
        Console.WriteLine($"Произведение элементов, кратных 7 = {pr}");
        Console.WriteLine($"Количество элементов, кратных 7 = {anof}");
    }
}