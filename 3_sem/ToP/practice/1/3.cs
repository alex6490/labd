using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите количество элементов: ");
        int c = Convert.ToInt32(Console.ReadLine());
        double[] numb = new double[c];
        double anumof = 0.0;
        for (int i = 0; i < c; i++)
        {
            Console.WriteLine("Введите " + (i + 1) + " элемент массива: ");
            numb[i] = Convert.ToDouble(Console.ReadLine());
            if (numb[i] >= 0)
            {
                anumof++;
            }

        }
        Console.WriteLine("Количество неотрицательных элементов: " + anumof);
    }
}