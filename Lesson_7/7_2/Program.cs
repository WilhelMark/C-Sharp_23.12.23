using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine()!);

        PrintNumbers(1, n); // вызов рекурсивной функции
    }

    static void PrintNumbers(int current, int n)
    {
        if (current > n) // базовый случай: если текущее число больше N, то выходим из функции
        {
            return;
        }

        Console.Write(current + " "); // выводим текущее число

        PrintNumbers(current + 1, n); // рекурсивный вызов функции для следующего числа
    }
}