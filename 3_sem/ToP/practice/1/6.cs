using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите количество элементов: ");
        int c = Convert.ToInt32(Console.ReadLine());
        double[] numb = new double[c];
        double sum = 0.0;
        for (int i = 0; i < c; i++)
        {
            Console.WriteLine("Введите элемент массива numb[" + i + "]:");
            numb[i] = Convert.ToDouble(Console.ReadLine());
            sum += numb[i];
        }
        double average = sum / c;
        Console.WriteLine("Среднее арифметическое элементов массива: " + average);
        Array.Resize(ref numb, c + 1);
        numb[c] = average;
        Console.WriteLine("Массив с добавленным средним арифметическим элементом: ");
        foreach (double num in numb)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine("");
    }
}