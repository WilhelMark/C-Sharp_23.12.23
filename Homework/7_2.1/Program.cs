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
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> cache = new Dictionary<string, int>();

    static void Main()
    {
        Console.Clear();
        int m = Prompt("Введите M: ");
        int n = Prompt("Введите N: ");

        try
        {
            if (m < 0 || n < 0)
            {
                throw new ArgumentException("m и n должны быть неотрицательными");
            }

            if (m > 3)
            {
                throw new ArgumentException("m не должно превышать 3 для этой реализации");
            }

            int result = Ackermann(m, n);
            Console.WriteLine($"A({m},{n}) = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Неверный формат ввода");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("Произошла ошибка");
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
    static int Ackermann(int m, int n)
    {
        string key = m.ToString() + "," + n.ToString();
        if (cache.ContainsKey(key))
        {
            return cache[key];
        }

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
            int result = Ackermann(m - 1, Ackermann(m, n - 1));
            cache[key] = result;
            return result;
        }
    }
}