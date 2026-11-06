using System;
public class Program
{
    public static void Main()
    {
        double sum = 0;
        int ct = 0;
        string sumbls;
        Console.WriteLine("Введите числа, если хотите закончить ввод введите 'y': ");
        while (true)
        {
            sumbls = Console.ReadLine();
            if (sumbls == "y" || sumbls == "Y")
                break;
            sum += Convert.ToDouble(sumbls);
            ct += 1;
        }
        Console.WriteLine($"Сумма {sum}");
        Console.WriteLine($"Среднее арифметическое введенных {ct} чисел = {sum/ct}");
    }
}