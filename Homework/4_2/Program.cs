using System;

// Создаем класс Program
class Program
{
    // Главный метод Main
    static void Main()
    {
        // Задаем размер массива
        int arraySize = 10;

        // Создаем массив и заполняем его случайными трехзначными числами
        int[] numbersArray = new int[arraySize];
        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            numbersArray[i] = random.Next(100, 1000);
        }

        // Вызываем функцию для подсчета количества четных чисел
        int evenNumbersCount = CountEvenNumbers(numbersArray);

        // Выводим исходный массив
        PrintArray("Исходный массив:", numbersArray);

        // Выводим результат
        Console.WriteLine("Количество четных чисел в массиве: " + evenNumbersCount);
    }

    // Функция для подсчета количества четных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
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