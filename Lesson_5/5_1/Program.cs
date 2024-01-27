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

    // Метод для замены элементов с четными индексами на их квадраты
    public static void ReplaceEvenElements(int[,] array)
    {
        int rows = array.GetLength(0); // Получаем количество строк массива
        int columns = array.GetLength(1); // Получаем количество столбцов массива

        for (int i = 0; i < rows; i++) // Перебираем строки массива
        {
            for (int j = 0; j < columns; j++) // Перебираем столбцы массива
            {
                if (i % 2 == 0 && j % 2 == 0) // Проверяем четность индексов
                {
                    array[i, j] = array[i, j] * array[i, j]; // Заменяем элемент на его квадрат
                }
            }
        }
    }

    // Метод для вывода массива на экран
    public static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0); // Получаем количество строк массива
        int columns = array.GetLength(1); // Получаем количество столбцов массива

        Console.WriteLine("Modified array:"); // Выводим заголовок измененного массива
        for (int i = 0; i < rows; i++) // Перебираем строки массива
        {
            for (int j = 0; j < columns; j++) // Перебираем столбцы массива
            {
                Console.Write($"{array[i, j]}\t"); // Выводим элемент массива с табуляцией
            }
            Console.WriteLine(); // Переходим на новую строку
        }
    }

    // Метод для вывода изначального массива на экран
    public static void PrintOriginalArray(int[,] array)
    {
        int rows = array.GetLength(0); // Получаем количество строк массива
        int columns = array.GetLength(1); // Получаем количество столбцов массива

        Console.WriteLine("Original array:"); // Выводим заголовок изначального массива
        for (int i = 0; i < rows; i++) // Перебираем строки массива
        {
            for (int j = 0; j < columns; j++) // Перебираем столбцы массива
            {
                Console.Write($"{array[i, j]}\t"); // Выводим элемент массива с табуляцией
            }
            Console.WriteLine(); // Переходим на новую строку
        }
    }
}

class Program
{
    static void Main()
    {
        int[,] array = ArrayManager.GenerateArray(3, 4); // Генерируем массив размером 3x4

        ArrayManager.PrintOriginalArray(array); // Выводим изначальный массив

        ArrayManager.ReplaceEvenElements(array); // Заменяем четные элементы на их квадраты

        ArrayManager.PrintArray(array); // Выводим измененный массив
    }
}
