using System;
class Program
{
    static void matrix_sum(ref int[,] a, ref int n, ref int m, out int[] sum)
    {
        sum = new int[n];
        for (int i = 0; i < n; i++)
        {
            sum[i] = 0;
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] >= 0)
                {
                    sum[i] += a[i, j];
                }
            }
        }
    }
    public static void Main()
    {
        Console.WriteLine("Введите количество строк матрицы:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов матрицы:");
        int cols = Convert.ToInt32(Console.ReadLine());
        Random rand = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(-100,100);
            }
        }
        int[] sum;
        matrix_sum(ref matrix, ref rows, ref cols, out sum);
        Console.WriteLine("Матрица: ");
        for (int i=0; i<rows; i++)
        {
            for (int j=0; j<cols; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine(" ");
        }
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Сумма элементов {i + 1}-й строки матрицы: {sum[i]}");
        }
    }
}