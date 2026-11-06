using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите количество элементов: ");
        int c = Convert.ToInt32(Console.ReadLine());
        double[] numb = new double[c];
        for (int i = 0; i < c; i++)
        {
            Console.WriteLine("Введите элемент массива numb[" + i+ "]:");
            numb[i] = Convert.ToDouble(Console.ReadLine());
        }
        int index = -1;
        double min = 0.0;
        for (int i = 0; i < c; i++)
        {
            if (numb[i] % 2 == 0)
            {
                if (index == -1 || numb[i] < min)
                {
                    min = numb[i];
                    index = i;
                }
            }
        }
        if (index != -1)
        {
            Console.WriteLine("Минимальный четный элемент: " + min);
            Console.WriteLine("Местоположение: " + index);
        }
        else
            Console.WriteLine("Четных элементов нет.");
    }
}
