using System;
public class Program
{
    public static void Main()
    {
        double x, y;
        Console.WriteLine("Введите значение y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение x: ");
        x = Convert.ToInt32(Console.ReadLine());
        if (x == 0 && y == 0)
        {
            Console.WriteLine("Точка лежит в начале координат");
        }
        else if (y != 0 && x == 0)
        {
            Console.WriteLine("Точка лежит на оси ординат");
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine("Точка лежит на оси абсцисс");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка лежит в 1-ой координатной четверти");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка лежит в 2-ой координатной четверти");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка лежит в 3-ей координатной четверти");
        }
        else
        {
            Console.WriteLine("Точка лежит в 4-ой координатной четверти");
        }
    }
}