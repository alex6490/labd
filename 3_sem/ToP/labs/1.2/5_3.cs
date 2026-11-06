using System;
public class Program
{
    public static void Main()
    {
        int A = 23, B = 64;
        int sum = 0;
        int i = (A%2==1)? A : A+1;
        do
        {
            sum+=i;
            i+=2;
        }
        while (i<=B);
        Console.WriteLine($"Сумма нечетных чисел от {A} до {B} = {sum}");
    }
}