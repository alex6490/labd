using System;
public class Program
{
    public static void Main()
    {
        int A = 23, B = 64;
        int sum = 0;
        int cur = (A%2==1)? A : A+1;
        while (cur<=B)
        {
            sum+=cur;
            cur+=2;
        }
        Console.WriteLine($"Сумма нечетных чисел от {A} до {B} = {sum}");
    }
}