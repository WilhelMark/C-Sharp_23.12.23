using System;

namespace RandomNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = GenerateRandomArray(n);
            PrintArray(arr);

            int number = FormNumberFromDigits(arr);
            Console.WriteLine("Сформированное число: " + number);
        }

        static int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, size);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            Console.Write("Сгенерированный массив: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static int FormNumberFromDigits(int[] array)
        {
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                number = number * 10 + array[i];
            }
            return number;
        }
    }
}