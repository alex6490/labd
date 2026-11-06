using System;
public class Program
{
    public static void Main()
{
    string n1, n2;

    Console.Write("Введите первое число: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите второе число: ");
    double y = Convert.ToDouble(Console.ReadLine());

    n1 = (x > y) ? "первое>второго" : (x < y ? "первое<второго" : "первое=второму"); //проверяем
    Console.WriteLine(n1);

    if (x > y)
    {
        n2 = "первое>второго";
    }
    else if (x < y)
    {
        n2 = "первое<второго";
    }
    else
    {
        n2 = "первое=второму";
    }

    Console.WriteLine(n2);
}
}