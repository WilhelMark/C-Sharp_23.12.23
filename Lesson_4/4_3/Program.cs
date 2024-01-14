/*
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

long Int1 (int [] arr) 
{
    string num = "";
    foreach (int item in arr)
    {
        num += item;
    }
    return long.Parse (num);
}
long result = Int1 (mass);
Console.WriteLine (result);
*/
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

            string number = FormNumberFromDigits(arr);
            Console.WriteLine("Сформированное число: " + number);
        }

        static int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 10);
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

        static string FormNumberFromDigits(int[] array)
        {
            string number = "";
            foreach (int item in array)
            {
                number += item;
            }
            return number;
        }
    }
}