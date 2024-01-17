using System;

// Создаем класс Program
class Program
{
    // Главный метод Main
    static void Main()
    {
        // Задаем размер массива и заполняем его случайными числами
        int arraySize = 10;
        int[] numbersArray = GenerateRandomArray(arraySize);

        // Выводим исходный массив
        PrintArray("Исходный массив:", numbersArray);

        // Реверсируем массив
        ReverseArray(numbersArray);

        // Выводим измененный массив
        PrintArray("Перевернутый массив:", numbersArray);
    }

    // Функция для генерации случайного массива заданного размера
    static int[] GenerateRandomArray(int size)
    {
        int[] array = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100);
        }
        return array;
    }

    // Функция для реверсирования массива
    static void ReverseArray(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            // Меняем местами элементы
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }
    }

    // Функция для вывода массива на экран
    static void PrintArray(string message, int[] array)
    {
        Console.WriteLine(message);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}