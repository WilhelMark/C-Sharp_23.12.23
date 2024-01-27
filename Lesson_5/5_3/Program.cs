/*
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

    // Метод для расчета средних значений по строкам и формирования одномерного массива
    public static int[] CalculateRowAverages(int[,] array)
    {
        int rows = array.GetLength(0); // Получаем количество строк в массиве
        int columns = array.GetLength(1); // Получаем количество столбцов в массиве
        int[] resultArray = new int[rows]; // Создаем новый одномерный массив для хранения средних значений
        for (int i = 0; i < rows; i++) // Перебираем строки массива
        {
            int sum = 0; // Инициализируем переменную для хранения суммы элементов в строке
            for (int j = 0; j < columns; j++) // Перебираем столбцы массива
            {
                sum += array[i, j]; // Считаем сумму элементов в строке
            }
            resultArray[i] = sum / columns; // Считаем среднее значение и записываем в новый массив
        }
        return resultArray; // Возвращаем одномерный массив со средними значениями
    }

    // Метод для расчета средних значений по столбцам и формирования одномерного массива
    public static int[] CalculateColumnAverages(int[,] array)
    {
        int rows = array.GetLength(0); // Получаем количество строк в массиве
        int columns = array.GetLength(1); // Получаем количество столбцов в массиве
        int[] resultArray = new int[columns]; // Создаем новый одномерный массив для хранения средних значений
        for (int j = 0; j < columns; j++) // Перебираем столбцы массива
        {
            int sum = 0; // Инициализируем переменную для хранения суммы элементов в столбце
            for (int i = 0; i < rows; i++) // Перебираем строки массива
            {
                sum += array[i, j]; // Считаем сумму элементов в столбце
            }
            resultArray[j] = sum / rows; // Считаем среднее значение и записываем в новый массив
        }
        return resultArray; // Возвращаем одномерный массив со средними значениями
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

            int[] rowAverages = ArrayManager.CalculateRowAverages(array); // Рассчитываем средние значения по строкам
            Console.WriteLine("\nArray of row averages:");
            Console.Write("[ ");
            foreach (int average in rowAverages)
            {
                Console.Write($"{average} ");
            }
            Console.Write("]"); // Выводим получившийся одномерный массив средних значений

            int[] columnAverages = ArrayManager.CalculateColumnAverages(array); // Рассчитываем средние значения по столбцам
            Console.WriteLine("\nArray of column averages:");
            Console.Write("[ ");
            foreach (int average in columnAverages)
            {
                Console.Write($"{average} ");
            }
            Console.Write("]"); // Выводим получившийся одномерный массив средних значений
        }
        catch (Exception ex)
        {
            // Обработка ошибок и исключений: выводим сообщение об ошибке
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
*/

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

    // Метод для расчета средних значений по строкам и формирования одномерного массива
    public static int[] CalculateRowAverages(int[,] array)
    {
        int rows = array.GetLength(0); // Получаем количество строк в массиве
        int columns = array.GetLength(1); // Получаем количество столбцов в массиве
        int[] resultArray = new int[rows]; // Создаем новый одномерный массив для хранения средних значений
        for (int i = 0; i < rows; i++) // Перебираем строки массива
        {
            int sum = 0; // Инициализируем переменную для хранения суммы элементов в строке
            for (int j = 0; j < columns; j++) // Перебираем столбцы массива
            {
                sum += array[i, j]; // Считаем сумму элементов в строке
            }
            resultArray[i] = sum / columns; // Считаем среднее значение и записываем в новый массив
        }
        return resultArray; // Возвращаем одномерный массив со средними значениями
    }

    // Метод для расчета средних значений по столбцам и формирования одномерного массива
    public static int[] CalculateColumnAverages(int[,] array)
    {
        int rows = array.GetLength(0); // Получаем количество строк в массиве
        int columns = array.GetLength(1); // Получаем количество столбцов в массиве
        int[] resultArray = new int[columns]; // Создаем новый одномерный массив для хранения средних значений
        for (int j = 0; j < columns; j++) // Перебираем столбцы массива
        {
            int sum = 0; // Инициализируем переменную для хранения суммы элементов в столбце
            for (int i = 0; i < rows; i++) // Перебираем строки массива
            {
                sum += array[i, j]; // Считаем сумму элементов в столбце
            }
            resultArray[j] = sum / rows; // Считаем среднее значение и записываем в новый массив
        }
        return resultArray; // Возвращаем одномерный массив со средними значениями
    }
}

class Program
{
    static void Main()
    {
        Console.Clear(); // Очистка терминала

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

            int[] rowAverages = ArrayManager.CalculateRowAverages(array); // Рассчитываем средние значения по строкам
            Console.WriteLine("\nArray of row averages:");
            Console.Write("[ ");
            foreach (int average in rowAverages)
            {
                Console.Write($"{average} ");
            }
            Console.Write("]"); // Выводим получившийся одномерный массив средних значений

            int[] columnAverages = ArrayManager.CalculateColumnAverages(array); // Рассчитываем средние значения по столбцам
            Console.WriteLine("\nArray of column averages:");
            Console.Write("[ ");
            foreach (int average in columnAverages)
            {
                Console.Write($"{average} ");
            }
            Console.Write("]"); // Выводим получившийся одномерный массив средних значений
        }
        catch (Exception ex)
        {
            // Обработка ошибок и исключений: выводим сообщение об ошибке
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}