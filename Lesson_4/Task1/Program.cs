using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = CreateMatrix(4, 5);
        ShowMatrix(matrix);
    }

    // Creates a matrix with the given number of rows and columns, filled with random numbers from 1 to 10
    static int[,] CreateMatrix(int rowsCount, int columnsCount)
    {
        int[,] matrix = new int[rowsCount, columnsCount];
        Random rnd = new Random();

        for (int i = 0; i < rowsCount; i++)
        {
            for (int j = 0; j < columnsCount; j++)
            {
                matrix[i, j] = rnd.Next(1, 11);
            }
        }

        return matrix;
    }

    // Prints the matrix to the console
    static void ShowMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}