using System;

class Program
{
    static void Main()
    {
        // Ввод значений M и N
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Вывод натуральных чисел в промежутке от M до N
        PrintNumbers(m, n);
    }

    // Рекурсивная функция для вывода чисел
    static void PrintNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.Write(start);
            if (start < end)
            {
                Console.Write(", ");
            }
            PrintNumbers(start + 1, end);
        }
    }
}