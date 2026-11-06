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
            Console.WriteLine("Введите " + (i + 1) + " элемент массива: ");
            numb[i] = Convert.ToDouble(Console.ReadLine());
        }
        double min = 0.0;
        bool found = false;
        for (int i = 0; i < c; i++)
        {
            if (numb[i] < 0 && numb[i] % 2 != 0)
            {
                if (!found || numb[i] < min)
                {
                    min = numb[i];
                    found = true;
                }
            }
        }
        if (found)
            Console.WriteLine("Минимальный отрицательный нечетный элемент: " + min);
        else
            Console.WriteLine("Такого элемента нет.");
    }
}