using System;
public class Program
{
    public static void Main()
    {
        double a, y, p, p1;
        Console.WriteLine("Введите значение a");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y");
        y = Convert.ToDouble(Console.ReadLine());
        //1способ
        if (a>=7)
        {
            p = 2*y+Math.Sqrt(7*Math.Pow(a,3));
        }
        else
        {
            p = 3*y-Math.Sin(7*Math.Pow(a,3));
        }
        Console.WriteLine(p);
        //2способ
        p1 = (a>=7)? 2*y+Math.Sqrt(7*Math.Pow(a,3)) : 3*y-Math.Sin(7*Math.Pow(a,3));
        Console.WriteLine(p1);
    }
}