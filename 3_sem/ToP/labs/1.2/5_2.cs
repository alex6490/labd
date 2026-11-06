using System;
public class Program
{
    public static void Main()
    {
        int A = 23, B = 64;
        int sum = 0;
        int i = (A%2==1)? A : A+1;
        for (sum = 0; i<=B; i+=2)
        {
            sum+=i;
        }
        Console.WriteLine($"Сумма нечетных чисел от {A} до {B} = {sum}");
    }
}