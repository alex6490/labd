using System;
class Program
{
    static long pr_max(long[] a1, long[] a2)
    {
        long max(long[] a)
        {
            long mx = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > mx)
                {
                    mx = a[i];
                }
            }
            return mx;
        }
        long m1 = max(a1);
        long m2 = max(a2);
        return (m1*m2);
    }
    public static void Main()
    {
        Console.WriteLine("Введите размер первого массива: ");
        long n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите размер второго массива: ");
        long n2 = Convert.ToInt32(Console.ReadLine());
        long[] a1 = new long[n1];
        long[] a2 = new long[n2];
        Console.WriteLine("Заполните массивы числами");
        for (int i=0; i<n1;i++)
        {
            Console.WriteLine($"Введите {i+1} член первого массива:");
            a1[i]=Convert.ToInt64(Console.ReadLine());
        }
        for (int i=0; i<n2;i++)
        {
            Console.WriteLine($"Введите {i+1} член второго массива:");
            a2[i]=Convert.ToInt64(Console.ReadLine());
        }
        long result = pr_max(a1, a2);
        Console.WriteLine("Произведение максимальных элементов двух массиво равно " + result);
    }
}