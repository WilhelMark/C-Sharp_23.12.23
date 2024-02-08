/*
using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReversed(arr, index - 1);
        }
    }
}
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        FillArrayWithRandomNumbers(array, 0);
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(array, 0);
        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReversed(array, array.Length - 1);
    }

    static void FillArrayWithRandomNumbers(int[] arr, int index)
    {
        if (index < arr.Length)
        {
            Random rnd = new Random();
            arr[index] = rnd.Next(1, 100); // Генерация случайного числа от 1 до 100
            FillArrayWithRandomNumbers(arr, index + 1);
        }
    }

    static void PrintArray(int[] arr, int index)
    {
        if (index < arr.Length)
        {
            Console.Write(arr[index] + " ");
            PrintArray(arr, index + 1);
        }
        else
        {
            Console.WriteLine();
        }
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReversed(arr, index - 1);
        }
    }
}
