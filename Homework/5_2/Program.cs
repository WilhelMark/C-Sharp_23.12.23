using System;

class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}  ");
            }
            Console.WriteLine();
        }
    }

    // Обмен первой и последней строк массива
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);
        int[] temp = new int[colCount];

        for (int i = 0; i < colCount; i++)
        {
            temp[i] = array[0, i];
            array[0, i] = array[rowCount - 1, i];
            array[rowCount - 1, i] = temp[i];
        }

        return array;
    }

    public static void PrintResult(int[,] numbers)
    {
        Console.WriteLine("Initial array:");
        PrintArray(numbers);

        Console.WriteLine("\nArray after swapping first and last rows:");
        int[,] swappedArray = SwapFirstLastRows(numbers);
        PrintArray(swappedArray);
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}