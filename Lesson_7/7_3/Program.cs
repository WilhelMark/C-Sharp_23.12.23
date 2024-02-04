using System;

class Program
{
    // Функция для проверки того, является ли символ согласным
    static bool IsConsonant(char c)
    {
        return "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".Contains(c);
    }

    // Рекурсивная функция для извлечения и отображения согласных из входной строки
    static void ExtractConsonants(string input, int index)
    {
        // Базовый случай: если индекс равен длине строки, остановите рекурсию
        if (index == input.Length)
            return;

        // Если символ в текущем индексе является согласным, отобразите его
        if (IsConsonant(input[index]))
            Console.Write(input[index] + " ");

        // Рекурсивный вызов функции со следующим индексом
        ExtractConsonants(input, index + 1);
    }

    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine()!;

        // Вызов рекурсивной функции для извлечения и отображения согласных
        ExtractConsonants(input, 0);
    }
}