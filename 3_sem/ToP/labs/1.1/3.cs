using System;
public class Program
{
    public static void Main()
    {
        double e, e1, x, y;
        Console.WriteLine("Введите x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y:");
        y = Convert.ToDouble(Console.ReadLine());
        //1способ
        if (y>=-7 && y<6)
        {
            e = Math.Sqrt(x)+Math.Cos(4*y);
            Console.WriteLine(e);
        }
        else if (y >= 6 && y <9)
        {
            e = -2*x+6*Math.Exp(-y);
            Console.WriteLine(e);
        }
        else if (y >= 9)
        {
            e = x*x+2*Math.Log(3*y);
            Console.WriteLine(e);
        }
        else
        {
            Console.WriteLine("Функция не определена на данном отрезке");
        }
        //2способ
        e1 = y >=6 ? (y<9 ? -2*x+6*Math.Exp(-y) : x*x+2*Math.Log(3*y)):(y>=-7? Math.Sqrt(x)+Math.Cos(4*y):0);
        Console.WriteLine(e1);
    }
}