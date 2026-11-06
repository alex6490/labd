using System;
public class Program
{
    public static void Main()
    {
        double e, x, y;
        Console.WriteLine("Введите x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y:");
        y = Convert.ToDouble(Console.ReadLine());
        //1способ
        if (y<6)
        {
            e = Math.Sqrt(x)+Math.Cos(4*y);
        }
        else if (y >= 6 && y <9)
        {
            e = -5*x+6*Math.Exp(-y);
        }
        else
        {
            e = x*x+2*Math.Log(3*y);
        }
        Console.WriteLine(e);
        //2способ
        e = (y<6)? Math.Sqrt(x)+Math.Cos(4*y) : (y>=9? x*x+2*Math.Log(3*y) : -5*x+6*Math.Exp(-y));
        Console.WriteLine(e);
    }
}