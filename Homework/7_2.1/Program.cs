/*
// код вычисляет значение функции Аккермана для заданных значений m и n

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        int m = 2; // Пример значений m и n
        int n = 2;
        Console.WriteLine("Ackermann(" + m + "," + n + ") is: " + Ackermann(m, n));
    }
}
*/

// функция растёт очень быстро, например, число A(4,4) настолько велико, что количество цифр в порядке этого числа многократно превосходит количество атомов в наблюдаемой части Вселенной
using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        int m = Prompt("Введите M: ");
        int n = Prompt("Введите N: ");

        try
        {
            int result = Akkerman(m, n);
            Console.WriteLine($"A({m},{n}) = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Возникла ошибка: {ex.Message}");
        }
    }

    // Функция для приглашения пользователя ввести целое число
    static int Prompt(string message)
    {
        Console.Write(message);
        int result;
        while (!int.TryParse(Console.ReadLine(), out result) || result < 0)
        {
            Console.WriteLine("Пожалуйста, введите целое неотрицательное число.");
            Console.Write(message);
        }
        return result;
    }

    // Рекурсивная функция для вычисления функции Аккермана
    static int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}