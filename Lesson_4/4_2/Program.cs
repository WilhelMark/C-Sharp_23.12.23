using System;

class Program
{
    static void Main()
    {
        // ввод размера массива с клавиатуры
        Console.WriteLine("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine()!);

        // ввод диапазона случайных чисел
        Console.WriteLine("Введите начало диапазона случайных чисел: ");
        int start = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите конец диапазона случайных чисел: ");
        int stop = int.Parse(Console.ReadLine()!);

        // генерация массива случайных чисел
        int[] mass = MassNums(size, start, stop);
        Print(mass);

        // определение количества чисел, которые оканчиваются на 1 и делятся на 7
        int count = 0;
        foreach (var number in mass)
        {
            if (number % 10 == 1 && number % 7 == 0) // проверка условий
            {
                count++;
            }
        }

        // вывод результата
        Console.WriteLine($"Количество чисел, оканчивающихся на 1 и делящихся нацело на 7: {count}");
    }

    // метод для генерации массива случайных чисел
    static int[] MassNums(int size, int from, int to)
    {
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(from, to + 1); // генерация случайного числа от from до to
        }
        return arr;
    }

    // метод для вывода массива на экран
    static void Print(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}
