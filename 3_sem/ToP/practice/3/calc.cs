using System;
class Calculator
{
    //Операция деления
    //float
    public static float Div(float x1, float x2, float x3, float x4, float x5, float x6)
    {
        float result = x1/x2/x3/x4/x5/x6;
        Console.WriteLine("Операция деления float (6 аргументов)");
        return result;
    }
    public static float Div(float x1, float x2, float x3, float x4, float x5, float x6, float x7)
    {
        float result = x1/x2/x3/x4/x5/x6/x7;
        Console.WriteLine("Операция деления float (7 аргументов)");
        return result;
    }
    //byte
    public static byte Div(byte x1, byte x2, byte x3, byte x4, byte x5, byte x6)
    {
        byte result = (byte)(x1/x2/x3/x4/x5/x6);
        Console.WriteLine("Операция деления byte (6 аргументов)");
        return result;
    }
    public static byte Div(byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
    {
        byte result = (byte)(x1/x2/x3/x4/x5/x6/x7);
        Console.WriteLine("Операция деления byte (7 аргументов)");
        return result;
    }
    //sbyte
    public static sbyte Div(sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6)
    {
        sbyte result = (sbyte)(x1/x2/x3/x4/x5/x6);
        Console.WriteLine("Операция деления sbyte (6 аргументов)");
        return result;
    }
    public static sbyte Div(sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7)
    {
        sbyte result = (sbyte)(x1/x2/x3/x4/x5/x6/x7);
        Console.WriteLine("Операция деления sbyte (7 аргументов)");
        return result;
    }
    //Операция вычитания
    //float
    public static float Min(float x1, float x2, float x3, float x4, float x5, float x6)
    {
        float dif = x1-x2-x3-x4-x5-x6;
        Console.WriteLine("Операция вычитания float (6 аргументов)");
        return dif;
    }
    public static float Min(float x1, float x2, float x3, float x4, float x5, float x6, float x7)
    {
        float dif = x1-x2-x3-x4-x5-x6-x7;
        Console.WriteLine("Операция вычитания float (7 аргументов)");
        return dif;
    }
    //byte
    public static byte Min(byte x1, byte x2, byte x3, byte x4, byte x5, byte x6)
    {
        byte dif = (byte)(x1-x2-x3-x4-x5-x6);
        Console.WriteLine("Операция вычитания byte (6 аргументов)");
        return dif;
    }
    public static byte Min(byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
    {
        byte dif = (byte)(x1-x2-x3-x4-x5-x6-x7);
        Console.WriteLine("Операция вычитания byte (7 аргументов)");
        return dif;
    }
    //sbyte
    public static sbyte Min(sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6)
    {
        sbyte dif = (sbyte)(x1-x2-x3-x4-x5-x6);
        Console.WriteLine("Операция вычитания sbyte (6 аргументов)");
        return dif;
    }
    public static sbyte Min(sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7)
    {
        sbyte dif = (sbyte)(x1-x2-x3-x4-x5-x6-x7);
        Console.WriteLine("Операция вычитания sbyte (7 аргументов)");
        return dif;
    }
    //Операция умножения
    //float
    public static float Per(float x1, float x2, float x3, float x4, float x5, float x6)
    {
        float pr = x1*x2*x3*x4*x5*x6;
        Console.WriteLine("Операция умножения float (6 аргументов)");
        return pr;
    }
    public static float Per(float x1, float x2, float x3, float x4, float x5, float x6, float x7)
    {
        float pr = x1*x2*x3*x4*x5*x6*x7;
        Console.WriteLine("Операция умножения float (7 аргументов)");
        return pr;
    }
    //byte
    public static byte Per(byte x1, byte x2, byte x3, byte x4, byte x5, byte x6)
    {
        byte pr = (byte)(x1*x2*x3*x4*x5*x6);
        Console.WriteLine("Операция умножения byte (6 аргументов)");
        return pr;
    }
    public static byte Per(byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
    {
        byte pr = (byte)(x1*x2*x3*x4*x5*x6*x7);
        Console.WriteLine("Операция умножения byte (7 аргументов)");
        return pr;
    }
    //sbyte
    public static sbyte Per(sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6)
    {
        sbyte pr = (sbyte)(x1*x2*x3*x4*x5*x6);
        Console.WriteLine("Операция умножения sbyte (6 аргументов)");
        return pr;
    }
    public static sbyte Per(sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7)
    {
        sbyte pr = (sbyte)(x1*x2*x3*x4*x5*x6*x7);
        Console.WriteLine("Операция умножения sbyte (7 аргументов)");
        return pr;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Деление float: ");
        Console.WriteLine(Calculator.Div(8.75f, 6.42f, 5.18f, 3.96f, 2.37f, 1.15f));
        Console.WriteLine(Calculator.Div(9.75f, 8.42f, 7.16f, 5.83f, 4.29f, 2.64f, 1.37f));
        Console.WriteLine("Деление byte:");
        Console.WriteLine(Calculator.Div((byte)250, 200, 150, 100, 50, 10));
        Console.WriteLine(Calculator.Div((byte)250, 200, 150, 100, 75, 50, 25));
        Console.WriteLine("Деление sbyte: ");
        Console.WriteLine(Calculator.Div((sbyte)127, 64, 32, 16, 8, 4));
        Console.WriteLine(Calculator.Div((sbyte)127, 100, 85, 64, 42, 21, -10));
        Console.WriteLine("Вычитание float: ");
        Console.WriteLine(Calculator.Min(98.7f, 76.4f, 53.2f, 41.8f, 27.5f, 13.9f));
        Console.WriteLine(Calculator.Min(7.8f, 6.4f, 5.9f, 4.7f, 3.3f, 2.1f, 0.6f));
        Console.WriteLine("Вычитаение byte: ");
        Console.WriteLine(Calculator.Min((byte)250, 200, 150, 100, 50, 25));
        Console.WriteLine(Calculator.Min((byte)250, 210, 170, 130, 90, 50, 10));
        Console.WriteLine("Вычитание sbyte");
        Console.WriteLine(Calculator.Min((sbyte)127, 100, 75, 50, 25, 10));
        Console.WriteLine(Calculator.Min((sbyte)120, 100, 80, 60, 40, 20, 10));
        Console.WriteLine("Умножение float");
        Console.WriteLine(Calculator.Per(1.0f, 2.0f, 3.0f, 0.5f, 2.5f, 1.5f));
        Console.WriteLine(Calculator.Per(1.25f, 2.4f, 0.75f, 3.2f, 1.5f, 0.8f, 2.25f));
        Console.WriteLine("Умножение byte");
        Console.WriteLine(Calculator.Per((byte)12, 3, 5, 2, 4, 1));
        Console.WriteLine(Calculator.Per((byte)12, 3, 7, 2, 5, 4, 6));
        Console.WriteLine("Умножение sbyte:");
        Console.WriteLine(Calculator.Per((sbyte)12, -3, 5, 2, -4, 7));
        Console.WriteLine(Calculator.Per((sbyte)12, -3, 5, -2, 4, 7, -1));
    }
}