using System;
abstract class Shape
{
    public abstract double GetSquare();
    public abstract double GetPerimetr();
}
class Convex_Quadriteral : Shape
{
    public double D1 { set; get;}
    public double D2 { set; get;}
    public int Angle {set; get;} //угол в градусах
    public double A{set; get;}
    public double B{set; get;}
    public double C{set; get;}
    public double D{set; get;}
    public double Radian
    {
        get{return Angle*Math.PI/180;}
    }
    public override double GetPerimetr() => A+B+C+D;
    public override double GetSquare() => 0.5*D1*D2*Math.Sin(Radian);
}
class Ellipse : Shape
{
    public double A{set; get;}
    public double B{set; get;}
    public override double GetPerimetr() => 2*Math.PI*Math.Sqrt((Math.Pow(A, 2)+Math.Pow(B, 2))/2);
    public override double GetSquare() => A*B*Math.PI;
}
class Program
{
    private static void PrintShape(Shape shape)
    {
        Console.WriteLine($"Фигура: {shape}, Периметр: {shape.GetPerimetr()}, Площадь: {shape.GetSquare()}");
    }
    static void Main(string[] args)
    {
        var convex_quadriteral0 = new Convex_Quadriteral{D1 = 8, D2 = 15, Angle = 30, A = 3, B=4, C=6, D=8};
        var convex_quadriteral1 = new Convex_Quadriteral{D1 = 5, D2 = 7, Angle = 90, A=5, B=7, C=9, D=4};
        var ellipse0 = new Ellipse{A=3, B=4};
        var ellipse1 = new Ellipse{A=5, B=7};
        PrintShape(convex_quadriteral0);
        PrintShape(convex_quadriteral1);
        PrintShape(ellipse0);
        PrintShape(ellipse1);
    }
}