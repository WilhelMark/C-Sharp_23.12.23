/*
using System;

class Program
{
    static void Main()
    {
            // Просим пользователя ввести строку
            Console.WriteLine("Введите строку из латинских букв в нижнем регистре:");
            string input = Console.ReadLine()!;

            int vowelCount = CountVowels(input);

            // Выводим результат
            Console.WriteLine($"Количество гласных букв в строке: {vowelCount}");
    }

    // Метод для подсчета количества гласных букв в строке
    private static int CountVowels(string input)
    {
        // Создаем массив с гласными буквами
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        
        int count = 0;
        
        // Проходим по каждому символу во введенной строке
        for (int i = 0; i < input.Length; i++)
        {
            // Если символ является гласной, увеличиваем счетчик
            if (Array.IndexOf(vowels, input[i]) != -1)
            {
                count++;
            }
        }
        
        return count;
    }
}
*/
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод строки от пользователя
            Console.WriteLine("Введите строку из латинских букв:");
            string input = Console.ReadLine().ToLower(); // Convert the input string to lowercase

            int vowelCount = CountVowels(input);

            // Отображение результата
            Console.WriteLine($"Количество гласных букв в строке: {vowelCount}");
        }
        catch (Exception ex)
        {
            // Вывод сообщение об ошибке, если было поймано исключение
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    // Метод для подсчета количества гласных букв во входной строке
    private static int CountVowels(string input)
    {
        // Создаем массив гласных букв
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        
        int count = 0;
        
        // Итерация по каждому символу во входной строке
        for (int i = 0; i < input.Length; i++)
        {
            // Если символ является гласным, увеличьте счетчик
            if (Array.IndexOf(vowels, input[i]) != -1)
            {
                count++;
            }
        }
        
        return count;
    }
}
