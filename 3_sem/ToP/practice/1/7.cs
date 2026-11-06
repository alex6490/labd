using System;
public class Program
{
    public static void Main()
    {
        int[,] matrix = new int[10, 10];
        int c = 10;
        int n = 0;
        int[] otr = new int[n];
        Random rand = new Random();
        for (int i = 0; i < c; i++)
        {
            for (int j = 0; j < c; j++)
            {
                matrix[i, j] = rand.Next(-100, 100);
                Console.Write(matrix[i, j] + " ");
                if (matrix[i, j] < 0 && matrix[i, j] % 2 == 0) 
                {
                    Array.Resize(ref otr, n + 1);
                    otr[n] = matrix[i, j];
                    n++;
                }
            }
            Console.WriteLine("");
        }
        Console.WriteLine("Отрицательные четные элементы двумерного массива: ");
        for (int i = 0; i<n; i++)
        {
            Console.Write(" " + otr[i] + " ");
        }
    }
}