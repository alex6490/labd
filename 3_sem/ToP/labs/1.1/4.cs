using System;
public class Program
{
    public static void Main()
    {
        double e, y;
        int x;

        Console.WriteLine("Введите значение y: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите целое значение x: ");
        x = Convert.ToInt32(Console.ReadLine());

        switch (x)
        {
            case 1:
                e = 1 + 2 * Math.Log(3 * y);
                Console.WriteLine("При x=1, e = " + e);
                break;

            case 2:
                e = 2 * 2 + 2 * Math.Log(3 * y);
                Console.WriteLine("При x=2, e = " + e);
                break;

            case 3:
                e = 3 * 3 + 2 * Math.Log(3 * y);
                Console.WriteLine("При x=3, e = " + e);
                break;
            default:
                Console.WriteLine("Задано неверное значение x");
                break;
        }

        Console.WriteLine("Окончание программы");
    }
}