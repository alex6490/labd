using System;
public class Program
{
    public static void Main()
    {
        double xn, x, xk, h, y;
        xn = -3;
        xk = 7;
        h = 1.0;
        x = xn;
        do
        {
            y = 3*Math.Pow(x,3)-9*x*x-Math.Sin(8*x);
            Console.WriteLine($"x = {x} \t y = {y}"); 
            x+=h;
        }
        while (x<=xk);
    }
}