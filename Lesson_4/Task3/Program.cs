using System;
using System.Text;

class Program
{
    // Метод для извлечения букв из строки
    static string GetLettersFromStr(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            throw new ArgumentNullException("s", "Необходимо ввести строку");
        }

        string letters = ""; // Создаем пустую строку для букв

        foreach (char e in s) // Проходим по каждому символу в исходной строке
        {
            if (char.IsLetter(e) || char.IsWhiteSpace(e)) // Проверяем, является ли текущий символ буквой или пробелом
            {
                letters = letters + e; // Если да, добавляем его к строке букв
            }
        }

        if (string.IsNullOrEmpty(letters))
        {
            throw new Exception("Во введенной строке отсутствуют буквы");
        }

        return letters; // Возвращаем строку, содержащую только буквы
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; // Устанавливаем кодировку консоли на UTF-8
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine(); // Считываем ввод пользователя в переменную str

        try
        {
            string letters = GetLettersFromStr(str); // Вызываем метод для извлечения букв из введенной строки
            Console.WriteLine("Результат: " + letters); // Выводим полученные буквы на консоль
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message); // Выводим сообщение об ошибке на консоль
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // Выводим сообщение об ошибке на консоль
        }
    }
}