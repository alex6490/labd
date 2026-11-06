using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите количество элементов: ");
        int c = Convert.ToInt32(Console.ReadLine());
        ulong[] numb = new ulong[c];
        for (int i = 0; i < c; i++)
        {
            Console.WriteLine("Введите " + (i + 1) + " элемент массива: ");
            numb[i] = Convert.ToUInt64(Console.ReadLine());
        }
        for (int i = 0; i < c - 1; i++)
        {
            for (int j = i + 1; j < c; j++)
            {
                if (numb[i] < numb[j])
                {
                    ulong temp = numb[i];
                    numb[i] = numb[j];
                    numb[j] = temp;
                }
            }
        }
        Console.WriteLine("Массив по убыванию:");
        for (int i = 0; i < c; i++)
        {
            Console.Write(numb[i] + " ");
        }
    }
}