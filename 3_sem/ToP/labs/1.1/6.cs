using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Введите первое число (Делимое): ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число (Делитель): ");
        int y = Convert.ToInt32(Console.ReadLine());

        // Проверка деления на ноль
        if (y == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль невозможно!");
        }

        // Проверка кратности
        if (x % y == 0)
        {
            Console.WriteLine("Число x=" + x + " делится на y=" + y + " без остатка.");
        }
        else
        {
            Console.WriteLine("Число x= " + x + " НЕ делится на y=" + y + " без остатка.");
        }
    }
}