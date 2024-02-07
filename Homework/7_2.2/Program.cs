using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int m = int.Parse(Console.ReadLine()!);
        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Четные числа в промежутке от {0} до {1}:", m, n);
        PrintEvenNumbers(m, n);
    }

    static void PrintEvenNumbers(int m, int n)
    {
        if (m > n)
        {
            return;
        }

        if (m % 2 == 0)
        {
            Console.Write(m + " ");
        }

        PrintEvenNumbers(m + 1, n);
    }
}