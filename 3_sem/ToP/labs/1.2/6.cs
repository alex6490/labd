using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите символ");
        char sumbls;
        int ct = -1;
        do
        {
            sumbls = Convert.ToChar(Console.ReadLine());
            ct += 1;
        }
        while (sumbls!='.');
        Console.WriteLine($"Введено {ct} символов");
    }
}