using System;

class ArrayManager
{
    // Метод для генерации двумерного массива
    public static int[,] GenerateArray(int rows, int columns)
    {
        int[,] array = new int[rows, columns]; // Создаем двумерный массив указанного размера
        Random random = new Random(); // Создаем объект для генерации случайных чисел

        for (int i = 0; i < rows; i++) // Перебираем строки массива
        {
            for (int j = 0; j < columns; j++) // Перебираем столбцы массива
            {
                array[i, j] = random.Next(1, 10); // Заполняем ячейку массива случайным числом от 1 до 10
            }
        }

        return array; // Возвращаем сгенерированный массив
    }

    // Метод для вычисления суммы элементов на главной диагонали
    public static int CalculateDiagonalSum(int[,] array)
    {
        int sum = 0; // Инициализируем переменную для хранения суммы элементов на диагонали
        int minSize = Math.Min(array.GetLength(0), array.GetLength(1)); // Вычисляем минимальное измерение массива

        for (int i = 0; i < minSize; i++) // Перебираем элементы на главной диагонали
        {
            sum += array[i, i]; // Увеличиваем сумму на значение элемента на диагонали
        }

        return sum; // Возвращаем вычисленную сумму
    }
}


class Program
{
    static void Main()
    {
        try
        {
            int[,] array = ArrayManager.GenerateArray(3, 4); // Генерируем массив размером 3x4

            // Выводим массив на экран для наглядности
            Console.WriteLine("Array:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            int diagonalSum = ArrayManager.CalculateDiagonalSum(array); // Вычисляем сумму элементов на главной диагонали
            Console.WriteLine($"\nSum of numbers on the main diagonal: {diagonalSum}"); // Выводим сумму на экран
        }
        catch (Exception ex)
        {
            // Обработка ошибок и исключений: выводим сообщение об ошибке
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
