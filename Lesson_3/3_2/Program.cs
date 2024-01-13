using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
         int[] array = new int[10] { -10, -5, 6, -1, 5, -6, 10, -3, 2, -4 };

        // Замена отрицательных на положительные и наоборот
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (array[i] < 0) ? -array[i] : array[i];
        }

        // Вывод результата
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}