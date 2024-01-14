/*
using System;

class Program
{
    static void Main()
    {
        //создаем объект Random для генерации случайных чисел
        Random random = new Random();
        //создаем массив из 10 случайных чисел
        int[] numbers = new int[10];
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100); //генерация случайного числа от 1 до 100
        }
        //определение кол-во простых чисел в массиве
        int count = 0;
        foreach (var number in numbers)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                count++;
            }
        }
        //вывод результата
        Console.WriteLine("Количество простых чисел в массиве: "+ count);
    }
    //метод для определения является ли число простым
    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
*/
using System;
using System.Collections.Generic;

class PrimeNumbersCounter
{
    // Метод для генерации случайного массива заданной длины
    public static int[] GenerateRandomArray(int length)
    {
        Random random = new Random();
        int[] numbers = new int[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100);
        }
        return numbers;
    }

    // Метод для подсчета количества простых чисел в массиве и вывода списка простых чисел
    public static void CountPrimeNumbers(int[] numbers, out int count, out List<int> primes)
    {
        count = 0;
        primes = new List<int>();
        foreach (var number in numbers)
        {
            if (IsPrime(number))
            {
                count++;
                primes.Add(number);
            }
        }
    }

    // Метод для определения является ли число простым
    public static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    // Метод для вывода результата на экран
    // primes - список простых чисел в массиве
    public static void PrintResult(int count, List<int> primes)
    {
        Console.WriteLine("Количество простых чисел в массиве: " + count);
        Console.WriteLine("Список простых чисел в массиве: " + string.Join(", ", primes));
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[] array;

        if (args.Length >= 1)
        {
            // Преобразуем аргумент командной строки в целое число
            int length = int.Parse(args[0]);
            array = PrimeNumbersCounter.GenerateRandomArray(length);
        }
        else
        {
            array = PrimeNumbersCounter.GenerateRandomArray(10);
        }

        int count;
        List<int> primes;
        PrimeNumbersCounter.CountPrimeNumbers(array, out count, out primes);
        PrimeNumbersCounter.PrintResult(count, primes);
    }
}
